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

        [SetUp]
        public void SetUp()
        {
            rothIraAccount = new RothIRA(1500, 10000, 59.5, 0.12, "Roth IRA Account", 100.00);
            investmentAccount = new InvestmentAccount(10000, 59.5, 0.12, "Investment Account", 100.00);
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
        public void MonthProgressAccountValue()
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

        [TearDown]
        public void TearDown()
        {
            rothIraAccount = null;
            investmentAccount = null;
        }
    }
}
