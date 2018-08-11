using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPiServer.Models.Projects
{
    public class Employe : Base.BaseModel
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public EmployeeType employeeType { get; set; }
    }

    public enum EmployeeType
    {
        engineer,
        jedi,
        pilot
    }
}