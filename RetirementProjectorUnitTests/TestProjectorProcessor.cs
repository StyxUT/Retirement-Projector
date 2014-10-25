using System;
using RetirementProjector;
using NUnit.Framework;
using System.Collections.Generic;

namespace RetirementProjectorUnitTests
{
    [TestFixture]
    public class TestProjectorProcessor
    {
        List<AccountBase> accounts = new List<AccountBase>();

        [SetUp]
        public void SetUp()
        {
           RetirementProjectorProcessor rpp = new RetirementProjectorProcessor(new RetirementSettings());

            accounts.Add(new RothIRA(1500, 10000, 59.5, 0.12, "Roth IRA Account", 100.00, 1000));
            accounts.Add(new InvestmentAccount(10000, 0.0, 0.12, "Investment Account", 100.00, 1000));
            accounts.Add(new StandardRetirementAccount(10000, 59.5, 0.12, "Standard Retirement Account", 100.00, 1000));
        }

        [Test]
        public void AllAccountsProgressedMonth()
        {
            //ProgressMonth
            //AdvanceMonth()
            Assert.Fail("Unimplemented Test");
        }

        [Test]
        public void RetirementAgeIsCalculated()
        {
            Assert.Fail("Unimplemented Test");
        }

        [Test]
        public void NewTest1()
        {
            Assert.Fail("Unimplemented Test");
        }

        [Test]
        public void NewTest()
        {
            Assert.Fail("Unimplemented Test");
        }
    }
}
