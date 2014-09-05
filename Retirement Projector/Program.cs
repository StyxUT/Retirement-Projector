using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetirementProjector
{
    static class Program
    {
        static RetirementSettings rs;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RetirementProjector());
            rs = new RetirementSettings();
            
        }

        public static void ProjectRetirement()
        {
            MessageBox.Show("ProjectRetiremnt(); called");

            //ToDo: relocate
            //ToDo: create class for reverse mortgate

            AccountBase account = new RothIRA(25000, 75000, 59.5, 0.08, "Vanguard Roth IRA", 458.33);
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName.ToString(), account.AccountValue.ToString()));

            AccountBase account2 = new InvestmentAccount(20000, 0, 0.14, "Lending Club", 160);
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName.ToString(), account.AccountValue.ToString()));

            AccountBase account3 = new InvestmentAccount(20000, 0, 0.14, "Fidelity IRA", 160);
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName.ToString(), account.AccountValue.ToString()));

            DateTime projectionDate = DateTime.Now.Date;
            
            //while (projectionDate < rs.BirthDate.)
        }

    }
}
