using CentumWebApplication.FCXService;
using CentumWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Xml.Schema;

namespace CentumWebApplication.Controllers
{
    public class HomeController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string cultureName = null;
            
            // Attempt to read the culture cookie from Request
            HttpCookie cultureCookie = Request.Cookies["_culture"];
            if (cultureCookie != null)
                cultureName = cultureCookie.Value;
            else
                cultureName = Request.UserLanguages != null && Request.UserLanguages.Length > 0 ?
                        Request.UserLanguages[0] :  // obtain it from HTTP header AcceptLanguages
                        null;
            // Validate culture name
            cultureName = CultureHelper.GetImplementedCulture(cultureName); // This is safe

            // Modify current thread's cultures            
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            return base.BeginExecuteCore(callback, state);
        }
        
        [HttpPost]
        [Route("AppInit", Name = "ApplicationInitiated")]
        public ActionResult ApplicationInitiated(FormViewModel model)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                MailMessage mailMessage = new MailMessage();

                mailMessage.To.Add(new MailAddress(model.user.AgentEmail));
                mailMessage.Subject = "Application Initiated";
                mailMessage.Body = "An application has been started on your Centum Web Application Form: \n" + "Name: " + model.applicant.firstName + " " + model.applicant.lastName + "\nEmail: " + model.applicant.email;
                if(!string.IsNullOrEmpty(model.applicant.homePhone))
                {
                    mailMessage.Body += "\nPhone: " + model.applicant.homePhone;
                }

                smtpClient.Send(mailMessage);
            }
            catch
            {

            }

            return View();
        }

        [Route("{culture}/{firmcode}/{username}", Name = "SetCulture")]
        public ActionResult SetCulture(string culture, string firmcode, string username, string url)
        {
            // Validate input
            culture = CultureHelper.GetImplementedCulture(culture);
            // Save culture in a cookie
            HttpCookie cookie = Request.Cookies["_culture"];
            if (cookie != null)
                cookie.Value = culture;   // update cookie value
            else
            {
                cookie = new HttpCookie("_culture");
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);
            return RedirectToAction("Index", new { firmcode = firmcode.ToUpper(), username = username.ToUpper(), url = url });
        }
        
        [Route("{firmcode}/{username}")]
        public ActionResult Index(string firmcode, string username, string url)
        {
            FormViewModel model = new FormViewModel(firmcode.ToUpper(), username.ToUpper(), url);
            return View(model);
        }
        
        [HttpPost]
        [Route("{firmcode}/{username}", Name = "FormSubmit")]
        public ActionResult Index(FormViewModel model)
        {
            if (ModelState.IsValid)
            {
                XDocument document = model.toXml();

                XmlSchemaSet schemas = new XmlSchemaSet();
                schemas.Add("http://www.filogix.com/Schema/FCXAPI/1", Server.MapPath("~/Models/XSD/referralApplication_1_0_1.xsd"));

                Console.WriteLine("Attempting to validate");

                bool errors = false;
                document.Validate(schemas, (o, e) =>
                {
                    ModelState.AddModelError("", e.Message);
                    errors = true;
                });
                Console.WriteLine("document {0}", errors ? "did not validate" : "validated");
                Console.WriteLine();

                if (!errors)
                {
                    try
                    {
                        //setMessage
                        FxLinkMessageSubmission fxlinkMessageSubmission = new FxLinkMessageSubmission(
                                ConfigurationManager.AppSettings["wsdl"],
                                ConfigurationManager.AppSettings["username"],
                                ConfigurationManager.AppSettings["password"],
                                ConfigurationManager.AppSettings["sendingChanel"],
                                ConfigurationManager.AppSettings["recevingChanel"] + model.firmCode.ToUpper() + "." + model.userName.ToUpper(),
                                "Referral Submission"
                            );

                        VersionedDocument vd = new VersionedDocument();
                        //Convert.ToBase64String(document.ToString());

                        vd.content = Encoding.UTF8.GetBytes(document.ToString());
                        vd.docname = "Referral Application";

                        List<VersionedDocument> docs = new List<VersionedDocument>();
                        docs.Add(vd);
                        
                        Response resp = fxlinkMessageSubmission.submitMessage(docs);
                        Response.Write(resp.status + " - " + resp.messageId);

                        try
                        {
                            string fileId = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
                            document.Save(Server.MapPath("~/Log/" + fileId +".xml"));
                        }
                        catch
                        {

                        }


                        //Console.WriteLine("Response: " + resp.status);

                        //getMessage
                        //VersionedMessage vm1 = fxlinkMessageSubmission.getMessage();

                        ////ackonwledge
                        //Response response = new Response();
                        //response.messageId = vm1.messageId;
                        //response.status = "OK";
                        //fxlinkMessageSubmission.acknowledge(response);
                    }
                    catch(Exception e)
                    {
                        ModelState.AddModelError("", e.Message);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if(string.IsNullOrEmpty(model.url))
                    TempData["success"] = "Form successfully submitted!";
                else
                    return Redirect(model.url);
            }
            
            return View(model);
        }
    }
}