﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            accounts.Add(new RothIRA(25000, 75000, 59.5, 0.08, "Vanguard Roth IRA", 458.33, rs.MonthlyExpenses));
            accounts.Add(new InvestmentAccount(20000, 0, 0.14, "Lending Club", 160, rs.MonthlyExpenses));
            accounts.Add(new StandardRetirementAccount(20000, 0, 0.14, "Fidelity IRA", 160, rs.MonthlyExpenses));
           
            DateTime retirementDate = rs.BirthDate.AddMonths((12 * 59) + 6); // number of months from birth until age 59.5

            for (DateTime projectionDate = DateTime.Now; projectionDate < retirementDate; projectionDate = projectionDate.AddMonths(1))
            {
                //do work here
            }
        
        }


        public void AdvanceMonth(List<AccountBase> Accounts)
        {
            foreach (AccountBase account in Accounts)
            {
                account.ProgressMonth();
                OutputAccountData(account);
            }
        }


        private void OutputAccountData(AccountBase Account)
        {
            MessageBox.Show(String.Format("Account Name:  {0}\nAccount Value:  {1}", Account.AccountName, Account.AccountValue));
        }

    }
}