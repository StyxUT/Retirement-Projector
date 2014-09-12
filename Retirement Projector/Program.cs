using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetirementProjector
{
    static class Program
    {
           
        
         

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RetirementProjector rp = new RetirementProjector();
            Application.Run(rp);
             
        }

        public static void ProjectRetirement()
        {

            List<AccountBase> Accounts = new List<AccountBase>();
            //ToDo: relocate
            //ToDo: create class for reverse mortgate

            Accounts.Add(new RothIRA(25000, 75000, 59.5, 0.08, "Vanguard Roth IRA", 458.33));
            Accounts.Add(new InvestmentAccount(20000, 0, 0.14, "Lending Club", 160));
            Accounts.Add(new StandardRetirementAccount(20000, 0, 0.14, "Fidelity IRA", 160));

           // DateTime retirementDate = new DateTime();
            //retirementDate = 
            //rs.BirthDate.AddMonths(714); // number of months from birth until age 59.5
           // MessageBox.Show(rs.BirthDate.ToShortDateString());
            
            DateTime projectionDate = DateTime.Now.Date;

            //while (projectionDate < retirementDate)
            //{
            //    account.ProgressMonth();
            //    account2.ProgressMonth();
            //    account3.ProgressMonth();

            //    projectionDate.AddMonths(1);
            //}

            OutputAccountData(projectionDate);
        }

        private static void OutputAccountData(DateTime projectionDate)
        {
            foreach (account in Accounts)
            {
                Console.WriteLine("Date:  ", projectionDate);
                Console.WriteLine("{0}:  {1};", account.AccountName, account.AccountValue);
            }
        }

    }
}
