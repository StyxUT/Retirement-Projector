using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    [Serializable]
    public class StandardRetirementAccount : AccountBase
    {
        public StandardRetirementAccount(RetirementSettings _RetirementSettings, decimal _AccountValue, decimal _AvailabilityAge, decimal _ARR, string _AccountName, decimal _MonthlyContribution, decimal _MonthlyExpenses) 
            : base(_RetirementSettings, _AccountValue, _AvailabilityAge, _ARR, _AccountName, _MonthlyContribution, _MonthlyExpenses)
        {   }
    }
}
