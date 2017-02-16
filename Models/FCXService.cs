using CentumWebApplication.FCXService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentumWebApplication.Models
{
    class FxLinkMessageSubmission
    {
        private String _url;
        private String _user;
        private String _pwd;
        private String _sender;
        private String _receiver;
        private String _transaction;

        private FCXServiceOverwrite fcxService;

        public FxLinkMessageSubmission(string serviceUrl, string userName, string password, string sender, string receiver, string transaction)
        {
            this._url = serviceUrl;
            this._user = userName;
            this._pwd = password;
            this._sender = sender;
            this._receiver = receiver;
            this._transaction = transaction;
        }
        /// <summary>
        /// Get service
        /// </summary>
        /// <returns></returns>
        private FCXServiceOverwrite getServiceCall()
        {
            if (fcxService == null)
            {
                fcxService = new FCXServiceOverwrite();
                fcxService.Url = _url;
                fcxService.setLogin(_user, _pwd);
            }
            return fcxService;
        }
        public VersionedMessage getMessage()
        { return getServiceCall().getMessage(_sender, "FCX", "1.1.0"); }

        public void acknowledge(Response resp)
        { getServiceCall().acknowledge(resp); }

        public Response submitMessage(List<VersionedDocument> documents)
        { return submitMessage(assembleMessage(documents)); }

        public Response submitMessage(VersionedMessage versionedMessage)
        {
            getServiceCall().Timeout = 600000;
            Response response = fcxService.setMessage(versionedMessage);
            if (response != null && response.status != null && !"OK".Equals(response.status, StringComparison.CurrentCultureIgnoreCase))
            {//handle submission error}
            }
                return response;
            }
        public VersionedMessage assembleMessage(List<VersionedDocument> documents)
        {
            VersionedMessage vm = new VersionedMessage();

            //Length of messageId shall be 32 or less
            vm.messageId = GetUniqID(); //Guid.NewGuid().ToString().Substring(9);
            //Length of dealId shall be 32 or less
            vm.dealId = "CNTM-" + GetUniqID();//Guid.NewGuid().ToString().Substring(9);
            //Length of sender shall be 76 or less
            vm.sender = _sender;
            //length of receiver shall be 42 or less
            vm.receiver = _receiver;
            vm.timestamp = DateTime.Now;
            vm.format = "FCXAPI";
            vm.version = "1.1.0";
            //Length of transaction shall be 30 or less
            vm.transaction = _transaction; //"Submit to Lender";

            if (documents != null)
            {
                foreach (VersionedDocument doc in documents)
                {
                    doc.format = "FCXAPI";
                    doc.mimetype = "base64Binary/xml";
                    doc.version = "1.1.0";
                }
                vm.documents = documents.ToArray();
            }
            return vm;
        }
        private string GetUniqID()
        {
            var ts = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            double t = ts.TotalMilliseconds / 1000;

            int a = (int)Math.Floor(t);
            int b = (int)((t - Math.Floor(t)) * 1000000);

            return a.ToString("x8") + b.ToString("x5");
        }

    }
}