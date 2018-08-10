using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RestAPiClient
{
    static class HttpHelper
    {
        public static HttpClient client = new HttpClient();
        public static readonly string baseApiLocation = @"http://localhost:65447/";
        

        #region init http
        public static void Init()
        {
            client.BaseAddress = new Uri(baseApiLocation);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion
    }
}
