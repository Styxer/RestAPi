using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        private static string _path;

        #region init http
        public static void Init()
        {
            client.BaseAddress = new Uri(baseApiLocation);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion

        #region call get all data from server
        public static async Task<IEnumerable<T>> getAll<T>(string controllerName)
        {
            _path = HttpHelper.baseApiLocation + @"/api/" + controllerName;
            IEnumerable<T> projects = null;
            HttpResponseMessage response = await HttpHelper.client.GetAsync(_path).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                projects = await response.Content.ReadAsAsync<IEnumerable<T>>();
            }
            return projects;
        }
        #endregion

        #region create a new item on server 
        static async Task<Uri> createItem<T>(string controllerName, T item)
        {
            _path = HttpHelper.baseApiLocation + @"/api/" + controllerName;
            HttpResponseMessage reponse = await client.PostAsJsonAsync(_path, item).ConfigureAwait(false);
            reponse.EnsureSuccessStatusCode();

            //return URI of the create resourcse
            return reponse.Headers.Location;
        }
        #endregion

        #region update an exisiting item
        static async Task<T> updateItem<T>(string controllerName, T item) where T : BaseModel
        {
            _path = HttpHelper.baseApiLocation + @"/api/" + controllerName;
            HttpResponseMessage response = await client.PostAsJsonAsync(_path + $"/{item.Id}", item);
            //TODO: check on existing ID ?
            response.EnsureSuccessStatusCode();

            // // Deserialize the updated item from the response body and return it.
            item = await response.Content.ReadAsAsync<T>();
            return item;
        }
        #endregion

        #region MyRegion
        static async Task<HttpStatusCode> deleteItem(string controllerName, string id)
        {
            _path = HttpHelper.baseApiLocation + @"/api/" + controllerName;
            HttpResponseMessage response = await client.DeleteAsync(_path + $"/{id}");
            return response.StatusCode;
        }
        #endregion


    }
}
