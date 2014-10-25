using System;
using System.Text;
using System.ComponentModel;

namespace RetirementProjector
{
    [DefaultPropertyAttribute("SaveOnClose")]
    public class RetirementSettings
    {
        private DateTime birthDate = DateTime.Parse("10/27/1972");
        private int ageAtRetirement = 50;
        private double inflationRate = 0.04;
        private int monthlyExpenses = 2000;
                
        
        [DescriptionAttribute ("Current DateTime projections are based on.")]
        public DateTime CurentProjectionDate { get; set; }


        [DefaultValue(2000),
        DescriptionAttribute("Current monthly expenses.\nExclude any expenses that wont be present at retirement./n E.g Mortgage, Work commute.")]
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

        [DescriptionAttribute("That date you were born.")]
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
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
