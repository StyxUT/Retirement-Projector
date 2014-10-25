using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    public class RothIRA : AccountBase
    {
        public RothIRA(RetirementSettings _RetirementSetttings, double _PreRetirementAccountValue, double _AccountValue, double _AvailabilityAge, double _ARR, string _AccountName, double _MonthlyContribution, double _MonthlyExpenses)
            : base(_RetirementSetttings, _AccountValue, _AvailabilityAge, _ARR, _AccountName, _MonthlyContribution, _MonthlyExpenses)
        { }

        public override bool CanWithdraw()
        { 
            //bool returnValue = false;

            //if preRetirementAccountValue > MonthlyExpenses
            //return returnValue;
            return true;
        }
    }
}
