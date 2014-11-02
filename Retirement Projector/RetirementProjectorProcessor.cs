using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetirementProjector;

namespace RetirementProjector
{
    public class RetirementProjectorProcessor
    {
        RetirementSettings rs;

        public RetirementProjectorProcessor(RetirementSettings retirementSetting)
        {
            rs = retirementSetting;
        }


        public void ProjectRetirement()
        {
            List<AccountBase> accounts = new List<AccountBase>();

            accounts.Add(new RothIRA(rs, 25000, 75000, 59.5M, 0.08M, "Vanguard Roth IRA", 458.33M, rs.MonthlyExpenses));
            accounts.Add(new InvestmentAccount(rs, 20000, 0M, 0.14M, "Lending Club", 160M, rs.MonthlyExpenses));
            accounts.Add(new StandardRetirementAccount(rs, 20000, 0M, 0.14M, "Fidelity IRA", 160M, rs.MonthlyExpenses));

            DateTime retirementDate = rs.BirthDate.AddMonths((12 * 59) + 6); // number of months from birth until age 59.5

            rs.CurrentProjectionAge = ProjectionHelpers.CalculateProjectionAge(rs.BirthDate, rs.CurentProjectionDate);
            //for (DateTime projectionDate = DateTime.Now; projectionDate < retirementDate; projectionDate = projectionDate.AddMonths(1))
            //{
                //foreach (AccountBase account in accounts)
                //{
                //    if (account.CanWithdraw())
                //        account.DeductMonthlyExpenses();
                //    break;
                //}

            rs.BirthDate = DateTime.Parse("10/10/1972");
            rs.CurentProjectionDate = DateTime.Parse("4/10/2032");

                rs.CurrentProjectionAge = ProjectionHelpers.CalculateProjectionAge(rs.BirthDate, rs.CurentProjectionDate);

                AdvanceMonth(accounts);
            //}
        }


        public void AdvanceMonth(List<AccountBase> Accounts)
        {
            foreach (AccountBase account in Accounts)
            {
                account.ProgressMonth();
                //OutputAccountData(account);
            }
            rs.CurrentProjectionAge = ProjectionHelpers.CalculateProjectionAge(rs.BirthDate, rs.CurentProjectionDate);
        }
        
        private void OutputAccountData(AccountBase Account)
        {
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", Account.AccountName, Account.AccountValue));
        }
    }
}
