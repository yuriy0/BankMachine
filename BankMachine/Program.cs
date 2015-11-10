using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMachine
{
    public static class Program
    {
    // Available screens. Make one screen for each set of views that share some information
        public static Form mainScreen;
        public static Form mainMenu;

        public static AccountDatabase db; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            db = new AccountDatabase();
            db.initDefault(); 

            mainScreen = new MainScreen();
            mainMenu = new MainMenu();

            Application.Run(mainScreen);
        }
    }
}
