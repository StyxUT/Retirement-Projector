using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement_Projector
{
    abstract class Account
    {

        private double preRetirementValue;
        private double postRetirementValue;
        private string accountName;

	    public string AccountName
	    {
		    get { return accountName;}
		    private set { accountName = value;}
	    }
	
	    public double PostRetirementValue
	    {
		    get { return postRetirementValue;}
		    private set { postRetirementValue = value;}
	    }

	    public double PreRetirementValue
	    {
		    get { return preRetirementValue;}
		    private set { preRetirementValue = value;}
	    }
		
        
        public virtual void AddMonthlyContribution(int ContributionAmount)
        {
            PreRetirementValue += ContributionAmount;
        }

        public virtual void AddMonthlyROI(double ReturnRate)
        {
            PreRetirementValue += PreRetirementValue * ReturnRate;
            PostRetirementValue += PostRetirementValue * ReturnRate;
        }

        public virtual void DeductMonthlyExpenses(int MonthlyExpense)
        {
            PostRetirementValue -= MonthlyExpense;
        }

        public virtual void OutputStatus()
        { 
        }
    }
}
