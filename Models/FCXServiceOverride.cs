using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace CentumWebApplication.Models
{
    class FCXServiceOverwrite : FCXService.FCXService
    {
        private String m_Username;
        private String m_Password;

        protected override WebRequest GetWebRequest(Uri uri)
        {
            // call the base class to get the underlying WebRequest object
            HttpWebRequest req = (HttpWebRequest)base.GetWebRequest(uri);

            if (null != this.m_Username || null != this.m_Password)
            {
                // set the header
                // the following format is required and should always be used when contacting
                // the link. i.e. ‘Authorization: Basic username:password’
                //		
                // the username and password combination has to be encoded with Base64
                req.Headers.Add("Authorization", "Basic " + base64Encode(this.m_Username + ":" + this.m_Password));
            }

            // return the WebRequest to the caller
            return (WebRequest)req;

        }

        public void setLogin(String username, String password)
        {
            this.m_Username = username;
            this.m_Password = password;
        }

        private string base64Encode(string data)
        {
            try
            {
                byte[] encData_byte = System.Text.Encoding.UTF8.GetBytes(data);
                return Convert.ToBase64String(encData_byte);
            }
            catch (Exception e)
            {
                throw new Exception("Error in FCXServiceOverwrite.base64Encode:" + e.Message);
            }
        }
    }
}