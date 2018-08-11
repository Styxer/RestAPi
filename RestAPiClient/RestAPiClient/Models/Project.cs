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


    


    }
}
