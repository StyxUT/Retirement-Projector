using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    [Serializable]
    public abstract class AccountBase
    {
        /// <summary>
        /// Retirement Account (Abstract)
        /// </summary>
        /// <param name="_RetirementSettings">Global settings object</param>
        /// <param name="_AccountValue">Current account value.</param>
        /// <param name="_AvailabilityAge">Age at which full amount is available.</param>
        /// <param name="_ARR">Annual Rate of Return.</param>
        /// <param name="_AccountName">Name of retirement account.</param>
        /// <param name="_MonthlyContribution">Amount contributed each month.</param>
        protected AccountBase(RetirementSettings _RetirementSettings, decimal _AccountValue, decimal _AvailabilityAge, decimal _ARR, string _AccountName, decimal _MonthlyContribution, decimal _MonthlyExpenses)
        {
            AccountValue = _AccountValue;
            AccountName = _AccountName;
            AvailabilityAge = _AvailabilityAge;
            AnnualReturnRate = _ARR;
            MonthlyContribution = _MonthlyContribution;
            rs = _RetirementSettings;
        }

        private decimal accountValue;
        private string accountName;
        private decimal availabilityAge;
        private decimal annualReturnRate;
        private decimal monthlyContribution;
        private RetirementSettings rs;

  
        private decimal MonthlyContribution
        {
            get { return monthlyContribution; }
            set { monthlyContribution = value; }
        }
        
        private decimal AnnualReturnRate
        {
            get { return annualReturnRate; }
            set { annualReturnRate = value; }
        }
        
        private decimal AvailabilityAge
        {
            get { return availabilityAge; }
            set { availabilityAge = value; }
        }

        public string AccountName
	    {
		    get { return accountName;}
		    private set { accountName = value;}
	    }
	
	    public decimal AccountValue
	    {
		    get { return accountValue;}
		    private set { accountValue = value;}
	    }

        public virtual bool CanWithdraw()
        { 
            bool canWithdraw = false;

            if (rs.CurrentProjectionAge >= AvailabilityAge && AccountValue >= rs.MonthlyExpenses)
                canWithdraw = true;

            return canWithdraw;
        }

        private void AddMonthlyContribution(decimal ContributionAmount)
        {
            AccountValue += ContributionAmount;
        }

        private void AddMonthlyROI(decimal ReturnRate)
        {
            AccountValue += AccountValue * ReturnRate;
        }

        public virtual void DeductMonthlyExpenses()
        {
            AccountValue -= rs.MonthlyExpenses;
        }

        public virtual void ProgressMonth()
        {
            // calculate ROI before adding in monthly contribution
            AddMonthlyROI(AnnualReturnRate / 12);
            AddMonthlyContribution(MonthlyContribution);
        }

   

    }
}
