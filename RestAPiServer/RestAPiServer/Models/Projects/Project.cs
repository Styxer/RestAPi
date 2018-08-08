using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class Project
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = String.Empty;
        public string CustName { get; set; } = String.Empty;
        public int CustId { get; set; } = 0;
        public double Tariff { get; set; } = 0;
    }
}