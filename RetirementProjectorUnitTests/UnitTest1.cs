using System;
using Retirement_Projector;
using NUnit.Framework;
using NSubstitute;


namespace RetirementProjectorUnitTests
{
    [TestFixture]
    public class RetirementProjectorUnitTests
    {
        Account retirementAccount;

        [SetUp]
        public void SetUp()
        {
            retirementAccount = new RothIRA(1500, 10000, 59.5, 0.12, "Roth IRA 1", 100.00);
        }

        [Test]
        public void AccountValueSet()
        {
            Assert.AreEqual(10000, retirementAccount.AccountValue);   
        }

        [Test]
        public void AccountNameSet()
        {
            Assert.AreEqual("Roth IRA 1", retirementAccount.AccountName);
        }

        [Test]
        public void MonthProgressAccountValue()
        {
            retirementAccount.ProgressMonth();
            Assert.AreEqual(10200.00, retirementAccount.AccountValue);
        }

        [Test]
        public void DeductMonthlyExpenses()
        {
            retirementAccount.DeductMonthlyExpenses(2500);
            Assert.AreEqual(7500.00, retirementAccount.AccountValue);
        }

        [TearDown]
        public void TearDown()
        {
            retirementAccount = null;
        }
    }
}
