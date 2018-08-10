using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestAPiClient
{
    class Project
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = String.Empty;
        public string CustName { get; set; } = String.Empty;
        public int CustId { get; set; } = 0;
        public double Tariff { get; set; } = 0;


        #region getAllProjectAsync
        public static async Task<IEnumerable<Project>> getAllProject()
        {
            string path = HttpHelper.baseApiLocation + @"/api/projects";
            IEnumerable<Project> projects = null;
            HttpResponseMessage response = await HttpHelper.client.GetAsync(path).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                projects = await response.Content.ReadAsAsync<IEnumerable<Project>>();
            }
            return projects;
        }
        #endregion
    }
}
