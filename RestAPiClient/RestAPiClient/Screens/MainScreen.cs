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

        private List<Form> _frms;
        private int _top = -1;
        private string _btnName;
        private static readonly string _btnPrefix = "to";

        public MainScreen()
        {
            InitializeComponent();
           
            _frms = Utilities.getAllavialbeScreen();
            initBtnsTags();
            HttpHelper.Init();
           
        }

        private void initBtnsTags()
        {
            int tag = 0;
            foreach (Control item in btnsPanel.Controls.Cast<Control>()
                .OrderBy(x => x.Location.Y))
            {
                if (item is Button)                
                    (item as Button).Tag = tag++;                

            }
        }

        private void LoadNewForm()
        {
            initNewForm();

            _frms[_top].TopLevel = false;
            _frms[_top].AutoScroll = false;          
            _frms[_top].Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(_frms[_top]);
            _frms[_top].Show();
        }

        private void initNewForm()
        {
            if (!_btnName.StartsWith(_btnPrefix))
                _btnName = _btnPrefix + _btnName;

            if (_btnName == toProjectsScreen.Name)            
                Utilities.ProjectsScreen.initScreen();
               
            
            else if (_btnName == toCustomersScreen.Name)            
                Utilities.customersScreen.initScreen();
                
           


        }

        //private void ToScreen_Click(object sender, EventArgs e)
        //{
        //    var btnName = (sender as Button).Name;

        //}

        private void ToScreen_Click(object sender, EventArgs e)
        {
            var btnTag = Convert.ToInt32((sender as Button).Tag);
            _btnName = (sender as Button).Name;
            _top = btnTag;
           
            LoadNewForm();

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            _top = 0;         
            _btnName = _frms[_top].Name;
            LoadNewForm();
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

