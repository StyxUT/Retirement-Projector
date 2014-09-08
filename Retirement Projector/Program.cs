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
            MessageBox.Show("ProjectRetiremnt(); called");

            //ToDo: relocate
            //ToDo: create class for reverse mortgate

            AccountBase account = new RothIRA(25000, 75000, 59.5, 0.08, "Vanguard Roth IRA", 458.33);
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName.ToString(), account.AccountValue.ToString()));

            AccountBase account2 = new InvestmentAccount(20000, 0, 0.14, "Lending Club", 160);
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName.ToString(), account.AccountValue.ToString()));

            AccountBase account3 = new InvestmentAccount(20000, 0, 0.14, "Fidelity IRA", 160);
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName.ToString(), account.AccountValue.ToString()));

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

            Console.WriteLine("Date:  ", projectionDate);
            Console.WriteLine("{0}:  {1};  {2}:  {3}; {4}:  {5};", account.AccountName, account.AccountValue, account2.AccountName, account2.AccountValue, account3.AccountName, account3.AccountValue);
        }

    }
}
