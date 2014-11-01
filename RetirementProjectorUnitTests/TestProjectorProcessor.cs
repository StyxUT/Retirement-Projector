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
        List<AccountBase> accounts = new List<AccountBase>();
        
        [SetUp]
        public void SetUp()
        {
            RetirementProjectorProcessor rpp = new RetirementProjectorProcessor(new RetirementSettings());
            rs = new RetirementSettings();

            accounts.Add(new RothIRA(rs, 1500, 10000, 59.5M, 0.12M, "Roth IRA Account", 100.00M, 1000));
            accounts.Add(new InvestmentAccount(rs, 10000, 0.0M, 0.12M, "Investment Account", 100.00M, 1000));
            accounts.Add(new StandardRetirementAccount(rs, 10000, 59.5M, 0.12M, "Standard Retirement Account", 100.00M, 1000));
        }

        [Test]
        public void AllAccountsProgressedMonth()
        {
            //ProgressMonth
            //AdvanceMonth()
            Assert.Fail("Unimplemented Test");
        }

        [Test]
        public void ProjectionAgeIsCalculated()
        {
            rs.BirthDate = DateTime.Parse("10/10/1972");
            rs.CurentProjectionDate = DateTime.Parse("4/10/2032");

            rs.CurentProjectionAge = ProjectionHelpers.CalculateProjectionAge(rs.BirthDate, rs.CurentProjectionDate);
            Assert.AreEqual(rs.CurentProjectionAge, 59.5M);
        }
    }
}
