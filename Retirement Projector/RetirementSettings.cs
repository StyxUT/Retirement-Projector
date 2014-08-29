using System;
using System.Text;
using System.ComponentModel;

namespace Retirement_Projector
{
    [DefaultPropertyAttribute("SaveOnClose")]
    public class RetirementSettings
    {
        private int age = 42;
        private int ageAtRetirement = 50;
        private double inflationRate = 0.04;
        private int monthlyExpenses = 2000;

        [DefaultValue(2000),
        DescriptionAttribute("Current monthy expenses.\nExclude any expenses that wont be present at retirment./n E.g Mortage, Work commute.")]
        public int MonthlyExpenses
        {
            get { return monthlyExpenses; }
            set { monthlyExpenses = value; }
        }


        [DefaultValue(0.04),
        DescriptionAttribute("Average inflation rate.")]
        public double InflationRate
        {
            get { return inflationRate; }
            set { inflationRate = value; }
        }

        [DefaultValue(41),
        DescriptionAttribute("Your curent age.")]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        [DefaultValueAttribute(55),
        DescriptionAttribute("Age at which you will stop contributing to retirement accounts and will start withdrawing money.")]
        public int AgeAtRetirement
        {
            get { return ageAtRetirement; }
            set { ageAtRetirement = value; }
        }
    }
}
