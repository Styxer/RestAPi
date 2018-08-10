using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPiClient
{
    public partial class MainScreen : Form
    {
       
        public int MyProperty { get; set; }

        public MainScreen()
        {
            InitializeComponent();
            HttpHelper.Init();
           
            
          
        }

        private void ToScreen_Click(object sender, EventArgs e)
        {
            var btnName = (sender as Button).Name;
            Form toScreen = null;
            if (btnName == toProjectScreenBtn.Name)
            {
                toScreen = Utilities.ProjectsScreen;
                Utilities.ProjectsScreen.initScreen();
            }

            Utilities.moveBetweenScreen(Utilities.MainScreen, toScreen);
        }





        //#region show a single project
        //static void showProject(Project project)
        //{
        //    System.Diagnostics.Trace.WriteLine($"Name: {project.Name}\tCustomer name: " +
        //        $"{project.CustName}\tTariff: {project.Tariff}");
        //}
        //#endregion

        //#region show all projects
        //static void showAllProjects(IEnumerable<Project> projects)
        //{
        //    foreach (var project in projects)
        //    {
        //        showProject(project);
        //    }
        //}
        //#endregion
    }
}

