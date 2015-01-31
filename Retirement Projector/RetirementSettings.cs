using System;
using System.Text;
using System.ComponentModel;

namespace RetirementProjector
{
    [Serializable]
    [DefaultPropertyAttribute("SaveOnClose")]
    public class RetirementSettings
    {
        [DescriptionAttribute ("Current DateTime projections are based on.")]
        public DateTime CurentProjectionDate { get; set; }

        [DescriptionAttribute("Current DateTime projections are based on.")]
        public decimal CurrentProjectionAge { get; set; }

        [DefaultValue(2000),
        DescriptionAttribute("Current monthly expenses.\nExclude any expenses that wont be present at retirement.\n E.g Mortgage, Work commute.")]
        public int MonthlyExpenses { get; set; }

        [DescriptionAttribute("DateTime when retirement begins.")]
        protected DateTime RetirementDate { get; set; }

        [DefaultValue(0.04),
        DescriptionAttribute("Average annual inflation rate.")]
        public decimal InflationRate { get; set; }

        [DefaultValue(10/27/2014),
        DescriptionAttribute("That date you were born.")]
        public DateTime BirthDate {get; set;}

        [DefaultValueAttribute(55),
        DescriptionAttribute("Age at which you will stop contributing to retirement accounts and will start withdrawing money.")]
        public int AgeAtRetirement
        { get; set; }

        [DescriptionAttribute("Date when retirement age is reached.")]
        public DateTime DateAtRetirement
        { get; set; }
    }
}
