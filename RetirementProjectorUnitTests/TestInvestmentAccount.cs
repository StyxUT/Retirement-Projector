using System;
using RetirementProjector;
using NUnit.Framework;


namespace RetirementProjectorUnitTests
{
    [TestFixture]
    public class RetirementProjectorUnitTests
    {
        AccountBase rothIraAccount;
        AccountBase investmentAccount;
        AccountBase standardRetirementAccount;

        [SetUp]
        public void SetUp()
        {
            rothIraAccount = new RothIRA(1500, 10000, 59.5, 0.12, "Roth IRA Account", 100.00);
            investmentAccount = new InvestmentAccount(10000, 0.0, 0.12, "Investment Account", 100.00);
            standardRetirementAccount = new StandardRetirementAccount(10000, 59.5, 0.12, "Standard Retirement Account", 100.00);
        }

        [Test]
        public void RothIraAccountValueSet()
        {
            Assert.AreEqual(10000, rothIraAccount.AccountValue);   
        }

        [Test]
        public void RothIraAccountNameSet()
        {
            Assert.AreEqual("Roth IRA Account", rothIraAccount.AccountName);
        }

        [Test]
        public void RothIraMonthProgressAccountValue()
        {
            rothIraAccount.ProgressMonth();
            Assert.AreEqual(10200.00, rothIraAccount.AccountValue);
        }

        [Test]
        public void RothIraAccountDeductMonthlyExpenses()
        {
            rothIraAccount.DeductMonthlyExpenses(2500);
            Assert.AreEqual(7500.00, rothIraAccount.AccountValue);
        }


        [Test]
        public void InvestmentAccountValueSet()
        {
            Assert.AreEqual(10000, investmentAccount.AccountValue);
        }

        [Test]
        public void InvestmentAccountNameSet()
        {
            Assert.AreEqual("Investment Account", investmentAccount.AccountName);
        }

        [Test]
        public void InvestmentAccountMonthProgressAccountValue()
        {
            investmentAccount.ProgressMonth();
            Assert.AreEqual(10200.00, investmentAccount.AccountValue);
        }

        [Test]
        public void InvestmentAccountDeductMonthlyExpenses()
        {
            investmentAccount.DeductMonthlyExpenses(2500);
            Assert.AreEqual(7500.00, investmentAccount.AccountValue);
        }

        [Test]
        public void StandardRetirementAccountValueSet()
        {
            Assert.AreEqual(10000, standardRetirementAccount.AccountValue);
        }

        [Test]
        public void StandardRetirementAccountNameSet()
        {
            Assert.AreEqual("Standard Retirement Account", standardRetirementAccount.AccountName);
        }

        [Test]
        public void StandardRetirementAccountMonthProgressAccountValue()
        {
            standardRetirementAccount.ProgressMonth();
            Assert.AreEqual(10200.00, standardRetirementAccount.AccountValue);
        }

        [Test]
        public void StandardRetirementAccountDeductMonthlyExpenses()
        {
            standardRetirementAccount.DeductMonthlyExpenses(2500);
            Assert.AreEqual(7500.00, standardRetirementAccount.AccountValue);
        }
        [TearDown]
        public void TearDown()
        {
            rothIraAccount = null;
            investmentAccount = null;
        }
    }
}
