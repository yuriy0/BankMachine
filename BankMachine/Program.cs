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
        public static MainScreen mainScreen;
        public static MainMenu mainMenu;
        public static Withdraw withdrawMenu;
        public static WithdrawConfirm withdrawConfirm;
        public static Balances balances;
        public static Transfer transfers;
        public static Deposit deposits;
        public static TransferConfirm transferConfirm;
        public static Payee payee;



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
            withdrawMenu = new Withdraw();
            withdrawConfirm = new WithdrawConfirm();
            balances = new Balances();
            transfers = new Transfer();
            deposits = new Deposit();
            transferConfirm = new TransferConfirm();
            payee = new Payee();
            Application.Run(mainScreen);
        }
    }
}
