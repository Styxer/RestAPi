using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPiClient.Models
{
    class Customer : BaseModel
    {
        public string CustName { get; set; } = String.Empty;
    }
}
