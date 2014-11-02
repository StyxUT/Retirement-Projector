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
        RetirementSettings rs;

        [SetUp]
        public void SetUp()
        {
            rs = new RetirementSettings();
            rs.MonthlyExpenses = 2500;
            rs.CurrentProjectionAge = 50;
            rothIraAccount = new RothIRA(rs, 1500, 10000, 59.5M, 0.12M, "Roth IRA Account", 100.00M, 1000);
            investmentAccount = new InvestmentAccount(rs, 10000, 0.0M, 0.12M, "Investment Account", 100.00M, 1000);
            standardRetirementAccount = new StandardRetirementAccount(rs, 10000, 59.5M, 0.12M, "Standard Retirement Account", 100.00M, 1000);
        }

        [Test]
        public void RothIraCanWithdrawAccountValue()
        {
            rs.CurrentProjectionAge = 59.5M;

            // Can cover full monthly expense
            rs.MonthlyExpenses = 1;
            Assert.True(rothIraAccount.CanWithdraw());

            // Can not cover full monthly expenses
            rs.MonthlyExpenses = 999999999;
            Assert.False(rothIraAccount.CanWithdraw());
        }

        [Test]
        public void RothIraCanWithdrawAge()
        {
            rs.MonthlyExpenses = 1;

            // less than standard retirement age
            rs.CurrentProjectionAge = 50.0M;
            Assert.True(rothIraAccount.CanWithdraw());

            // standard retirement age
            rs.CurrentProjectionAge = 59.5M; 
            Assert.True(rothIraAccount.CanWithdraw());
        }

        [Test]
        public void InvestmentAccountCanWithdrawAccountValue()
        {
            rs.CurrentProjectionAge = 60.0M;

            // Can cover full monthly expense
            rs.MonthlyExpenses = 1;
            Assert.True(investmentAccount.CanWithdraw());

            // Can not cover full monthly expenses
            rs.MonthlyExpenses = 99999999;
            Assert.False(investmentAccount.CanWithdraw());
        }

        [Test]
        public void InvestmentAccountCanWithdrawAge()
        {
            rs.MonthlyExpenses = 1;

            // less than standard retirement age
            rs.CurrentProjectionAge = 59.4M;
            Assert.True(investmentAccount.CanWithdraw());

            // standard retirement age
            rs.CurrentProjectionAge = 59.5M;
            Assert.True(investmentAccount.CanWithdraw());
        }

        [Test]
        public void StandardRetirementAccountCanWithdrawValue()
        {
            rs.CurrentProjectionAge = 60.0M;
            // Can cover full monthly expense
            rs.MonthlyExpenses = 1;
            Assert.True(standardRetirementAccount.CanWithdraw());

            // Can not cover full monthly expenses
            rs.MonthlyExpenses = 99999999;
            Assert.False(standardRetirementAccount.CanWithdraw());
        }

        [Test]
        public void StandardRetirementAccountCanWithdrawAge()
        {
            rs.MonthlyExpenses = 1;

            // less than standard retirement age
            rs.CurrentProjectionAge = 59.5M;
            Assert.True(investmentAccount.CanWithdraw());

            // standard retirement age
            rs.CurrentProjectionAge = 59.4M;
            Assert.True(investmentAccount.CanWithdraw());
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
            rothIraAccount.DeductMonthlyExpenses();
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
            investmentAccount.DeductMonthlyExpenses();
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
            standardRetirementAccount.DeductMonthlyExpenses();
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
