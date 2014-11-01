using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    public class RothIRA : AccountBase
    {
        RetirementSettings rs;
        decimal PreRetirementAccountValue;

                
        public RothIRA(RetirementSettings _RetirementSetttings, decimal _PreRetirementAccountValue, decimal _AccountValue, decimal _AvailabilityAge, decimal _ARR, string _AccountName, decimal _MonthlyContribution, decimal _MonthlyExpenses)
            : base(_RetirementSetttings, _AccountValue, _AvailabilityAge, _ARR, _AccountName, _MonthlyContribution, _MonthlyExpenses)
        {
            rs = _RetirementSetttings;
            PreRetirementAccountValue = _PreRetirementAccountValue;
         }

        public override bool CanWithdraw()
        {
            bool canWithdraw = false;

            if (rs.CurentProjectionAge < 59.5M && PreRetirementAccountValue >= rs.MonthlyExpenses)
                canWithdraw = true;
            else if (rs.CurentProjectionAge >= 59.5M && AccountValue >= rs.MonthlyExpenses)
                canWithdraw = true;
            else
                canWithdraw = false;

            return canWithdraw;
        }
    }
}
