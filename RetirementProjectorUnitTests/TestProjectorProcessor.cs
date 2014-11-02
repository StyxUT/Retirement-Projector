using System;
using RetirementProjector;
using NUnit.Framework;
using System.Collections.Generic;


namespace RetirementProjectorUnitTests
{
    [TestFixture]
    public class TestProjectorProcessor
    {
        RetirementSettings rs;
        RetirementProjectorProcessor rpp;

        List<AccountBase> Accounts = new List<AccountBase>();
        
        [SetUp]
        public void SetUp()
        {
            rpp = new RetirementProjectorProcessor(new RetirementSettings());
            rs = new RetirementSettings();

            Accounts.Add(new RothIRA(rs, 1500, 10000, 59.5M, 0.12M, "Roth IRA Account", 100.00M, 1000));
            Accounts.Add(new InvestmentAccount(rs, 10000, 0.0M, 0.12M, "Investment Account", 100.00M, 1000));
            Accounts.Add(new StandardRetirementAccount(rs, 10000, 59.5M, 0.12M, "Standard Retirement Account", 100.00M, 1000));
        }

        [Test]
        public void AllAccountsAdvanceMonth()
        {
            bool monthAdvanced = true;

            List<AccountBase> AccountsClone = GenericCopier<List<AccountBase>>.DeepCopy(Accounts);
            rpp.AdvanceMonth(Accounts);

            for (int i = 0; i < Accounts.Count; i++)
            {
                AccountBase account = Accounts[i];
                AccountBase cloneAccount = AccountsClone[i];

                if (account.AccountValue <= cloneAccount.AccountValue)
                {
                    monthAdvanced = false;
                    break;
                }
            }

            Assert.True(monthAdvanced);
        }

        [Test]
        public void ProjectionAgeIsCalculated()
        {
            rs.BirthDate = DateTime.Parse("10/10/1972");
            rs.CurentProjectionDate = DateTime.Parse("4/10/2032");

            rs.CurrentProjectionAge = ProjectionHelpers.CalculateProjectionAge(rs.BirthDate, rs.CurentProjectionDate);
            Assert.AreEqual(rs.CurrentProjectionAge, 59.5M);
        }
    }
}
