using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

           // rs.RetirementDate = rs.BirthDate.AddMonths((12 * 59) + 6); // number of months from birth until age 59.5

            rs.CurrentProjectionAge = ProjectionHelpers.CalculateProjectionAge(rs.BirthDate, rs.CurentProjectionDate);
            //for (DateTime projectionDate = DateTime.Now; projectionDate < retirementDate; projectionDate = projectionDate.AddMonths(1))
            //{
                //foreach (AccountBase account in accounts)
                //{
                //    if (account.CanWithdraw())
                //        account.DeductMonthlyExpenses();
                //    break;
                //}

                rs.CurrentProjectionAge = ProjectionHelpers.CalculateProjectionAge(rs.BirthDate, rs.CurentProjectionDate);

                for (int i = 0; i < 5; i++)
                {
                    AdvanceMonth(accounts);
                }
            //}
        }


        public void AdvanceMonth(List<AccountBase> Accounts)
        {
            foreach (AccountBase account in Accounts)
            {
                account.ProgressMonth();
            }
            rs.CurrentProjectionAge = ProjectionHelpers.CalculateProjectionAge(rs.BirthDate, rs.CurentProjectionDate);
            OutputAccountData(Accounts);
        }

        private void OutputAccountData(List<AccountBase> Accounts)
        {
            foreach (AccountBase account in Accounts)
            {
                MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", account.AccountName, account.AccountValue));
            }
        }
    }
}
