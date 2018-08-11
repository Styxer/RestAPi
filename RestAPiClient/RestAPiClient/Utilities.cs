using RestAPiClient.Screens;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPiClient
{
    static class Utilities
    {
        public static MainScreen MainScreen { get; set; }
        public static ProjectsScreen ProjectsScreen { get; set; }
        public static CustomersScreen customersScreen { get; set; }
        //public static ProjectsScreen ProjectsScreen { get; set; }

        public static void moveBetweenScreen(Form fromScreen, Form toScreen)
        {
            fromScreen.Hide();
            toScreen.Show();
        }

        public static void createAllScreenHandles()
        {
            
            Utilities.ProjectsScreen = new ProjectsScreen();
            Utilities.customersScreen = new CustomersScreen();

            Utilities.MainScreen = new MainScreen();
        }

        public static List<Form> getAllavialbeScreen()
        {
            var forms = new List<Form>();
            forms.Add(Utilities.customersScreen);
            forms.Add(Utilities.ProjectsScreen);
            
            return forms;

        }
    }
}
