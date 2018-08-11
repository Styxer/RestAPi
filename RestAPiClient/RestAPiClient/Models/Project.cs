using RestAPiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestAPiClient
{
    class Project  :BaseModel
    {
        public Customer Customer { get; set; }
        public string ProjectName { get; set; } = String.Empty;        
        public double Tariff { get; set; } = 0;


        #region getAllProjectAsync
        public static async Task<IEnumerable<T>> getAllProject<T>(string controllerName)
        {
            string path = HttpHelper.baseApiLocation + @"/api/"+ controllerName;
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
