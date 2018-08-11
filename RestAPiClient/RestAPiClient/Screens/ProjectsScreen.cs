using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPiClient
{
    public partial class ProjectsScreen : baseContentPanel
    { 

        List<Project> _projects;
        static readonly string controllerName = "projects";

        public ProjectsScreen()
        {
            InitializeComponent();
         
        }

        public async void  initScreen()
        {
          //  var customers = 
            var result = await HttpHelper.getAll<Project>(controllerName);
            _projects = result.ToList();        
            setItemToDataGrid();
        }

        private void setItemToDataGrid()
        {
            for (int i = 0; i < _projects.Count(); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = _projects[i].Id;
                row.Cells[1].Value = _projects[i].ProjectName;
                row.Cells[2].Value = _projects[i].Customer.Id;
                row.Cells[3].Value = _projects[i].Customer.CustName;
                row.Cells[4].Value = _projects[i].Tariff;
                dataGridView1.Rows.Add(row);

            }

        }

     
    }
}
