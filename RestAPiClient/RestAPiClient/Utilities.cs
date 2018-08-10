using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPiClient
{
    static class Utilities
    {
        public static MainScreen MainScreen { get; set; }
        public static ProjectsScreen ProjectsScreen { get; set; }
        //public static ProjectsScreen ProjectsScreen { get; set; }
        //public static ProjectsScreen ProjectsScreen { get; set; }

        public static void moveBetweenScreen(Form fromScreen, Form toScreen)
        {
            fromScreen.Hide();
            toScreen.Show();
        }

        public static void createAllScreenHandles()
        {
            Utilities.MainScreen = new MainScreen();
            Utilities.ProjectsScreen = new ProjectsScreen();
        }
    }
}
