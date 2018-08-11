using RestAPiClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPiClient.Screens
{
    public partial class CustomersScreen : baseContentPanel
    {
        private static readonly string controllerName = "Customers";
        public CustomersScreen()
        {
            InitializeComponent();
           
        }

        public async void initScreen()
        {
            //  var customers = 
            var result = await HttpHelper.getAll<Customer>(controllerName);
            dataGridView1.DataSource = result;


        }
    }
}
