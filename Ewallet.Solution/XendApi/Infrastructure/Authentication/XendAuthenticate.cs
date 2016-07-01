using Newtonsoft.Json;
using System;
using System.Net;
using XendApi.Configuration;
using XendApi.Interface;

namespace XendApi.Infrastructure.Authentication
{
    public class XendAuthenticate : IAuthenticate
    {
        private IXendCredentials _xendConfig;

        public XendAuthenticate(IXendCredentials xendConfig)
        {
            this._xendConfig = xendConfig;
            this.XKey = xendConfig.XKey;
            this.XPass = xendConfig.Xpass;
            this.UrlEndPoint = new Uri(XENDENDPOINTCONFIG.AUTHENTICATE_END_POINT + XENDENDPOINTCONFIG.XEND_TEST_APP_ID);
        }

        public string XKey { private get; set; }

        public string XPass { private get; set; }

        public Uri UrlEndPoint { private get; set; }

        public string Authenticate()
        {
            string token = string.Empty;

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json;charset=utf-8";
                client.Headers.Add("xKey", this.XKey);
                client.Headers.Add("xPass", this.XPass);

                var response = client.UploadString(this.UrlEndPoint, "{}");

                var result = JsonConvert.DeserializeObject<XendTokenAccount>(response);

                token = result.Token;
            }

            return token;
        }
    }
}
