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

        #region call get all data from some controller
        public static async Task<IEnumerable<T>> getAllProject<T>(string controllerName)
        {
            string path = HttpHelper.baseApiLocation + @"/api/" + controllerName;
            IEnumerable<T> projects = null;
            HttpResponseMessage response = await HttpHelper.client.GetAsync(path).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                projects = await response.Content.ReadAsAsync<IEnumerable<T>>();
            }
            return projects;
        }
        #endregion
    }
}
