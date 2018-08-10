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
    public partial class ProjectsScreen : Form
    {
        public ProjectsScreen()
        {
            InitializeComponent();
        }

        public async void  initScreen()
        {
            var projects = await Project.getAllProject();
            dataGridView1.DataSource = projects;
        }
    }
}
