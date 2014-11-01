using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    public class RothIRA : AccountBase
    {
        public RothIRA(RetirementSettings _RetirementSetttings, decimal _PreRetirementAccountValue, decimal _AccountValue, decimal _AvailabilityAge, decimal _ARR, string _AccountName, decimal _MonthlyContribution, decimal _MonthlyExpenses)
            : base(_RetirementSetttings, _AccountValue, _AvailabilityAge, _ARR, _AccountName, _MonthlyContribution, _MonthlyExpenses)
        { }

        //public override bool CanWithdraw()
        //{
        //    bool canWithdraw = false;

        //    return canWithdraw;
        //}
    }
}
