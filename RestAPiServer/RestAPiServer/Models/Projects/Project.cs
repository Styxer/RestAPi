using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class Project : Base.BaseModel
    {       
        public string ProjectName { get; set; } = String.Empty;
        public Customer customer { get; set; }
        //public string CustName { get; set; } = String.Empty;
        //public int CustId { get; set; } = 0;
        public double Tariff { get; set; } = 0;
    }
}