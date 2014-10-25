using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    public class InvestmentAccount : AccountBase
    {
        public InvestmentAccount(RetirementSettings _RetirementSettings, double _AccountValue, double _AvailabilityAge, double _ARR, string _AccountName, double _MonthlyContribution, double _MonthlyExpenses)
            : base(_RetirementSettings, _AccountValue, _AvailabilityAge, _ARR, _AccountName, _MonthlyContribution, _MonthlyExpenses)
        { }

        public override bool CanWithdraw()
        {
            throw new NotImplementedException();
        }
    }
}