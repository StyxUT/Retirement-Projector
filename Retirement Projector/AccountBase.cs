using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    public abstract class AccountBase
    {
        /// <summary>
        /// Retirement Account (Abstract)
        /// </summary>
        /// <param name="_RetirementSettings">Global settings object</param>
        /// <param name="_AccountValue">Current account value.</param>
        /// <param name="_AvailabilityAge">Age at which full amount is available.</param>
        /// <param name="_ARR">Anual Rate of Return.</param>
        /// <param name="_AccountName">Name of retirement account.</param>
        /// <param name="_MonthlyContribution">Amount contributed each month.</param>
        protected AccountBase(RetirementSettings _RetirementSettings, double _AccountValue, double _AvailabilityAge, double _ARR, string _AccountName, double _MonthlyContribution, double _MonthlyExpenses)
        {
            AccountValue = _AccountValue;
            AccountName = _AccountName;
            AvailabilityAge = _AvailabilityAge;
            AnnualReturnRate = _ARR;
            MonthlyContribution = _MonthlyContribution;
            rs = _RetirementSettings;
        }

        private double accountValue;
        private string accountName;
        private double availabilityAge;
        private double annualReturnRate;
        private double monthlyContribution;
        private RetirementSettings rs;

  
        private double MonthlyContribution
        {
            get { return monthlyContribution; }
            set { monthlyContribution = value; }
        }
        
        private double AnnualReturnRate
        {
            get { return annualReturnRate; }
            set { annualReturnRate = value; }
        }
        
        private double AvailabilityAge
        {
            get { return availabilityAge; }
            set { availabilityAge = value; }
        }

        public string AccountName
	    {
		    get { return accountName;}
		    private set { accountName = value;}
	    }
	
	    public double AccountValue
	    {
		    get { return accountValue;}
		    private set { accountValue = value;}
	    }

        public virtual bool CanWithdraw()
        { 
            bool canWithdraw = false;
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = rs.BirthDate.AddYears(rs.AgeAtRetirement) - rs.CurentProjectionDate;
            
            double ProjectionAge = (zeroTime + span).Year - 1;

            if (ProjectionAge >= AvailabilityAge && AccountValue >= rs.MonthlyExpenses)
                canWithdraw = true;

            return canWithdraw;
        }

        private void AddMonthlyContribution(double ContributionAmount)
        {
            AccountValue += ContributionAmount;
        }

        private void AddMonthlyROI(double ReturnRate)
        {
            AccountValue += AccountValue * ReturnRate;
        }

        public virtual void DeductMonthlyExpenses()
        {
            AccountValue -= rs.MonthlyExpenses;
        }

        public virtual void ProgressMonth()
        {
            // calcluate ROI before adding in monthly contribution
            AddMonthlyROI(AnnualReturnRate / 12);
            AddMonthlyContribution(MonthlyContribution);
        }

   

    }
}
