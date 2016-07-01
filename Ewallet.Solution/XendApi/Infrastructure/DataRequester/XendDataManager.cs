using Newtonsoft.Json;
using System;
using System.Net;

namespace XendApi.Infrastructure.DataRequester
{
    public class XendDataManager
    {

        public static string GetData(Uri url, string parameters)
        {
            string response = string.Empty;

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded;charset=utf-8";

                response = client.UploadString(url, "POST", parameters);
            }

            return response;
        }

        public static T GetObjects<T>(string jsonResponse)
        {
            T result = JsonConvert.DeserializeObject<T>(jsonResponse);

            return result;
        }
    }
}
