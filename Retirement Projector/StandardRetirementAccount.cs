using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    class StandardRetirementAccount : AccountBase
    {
        public StandardRetirementAccount(double _AccountValue, double _AvailabilityAge, double _ARR, string _AccountName, double _MonthlyContribution) : base(_AccountValue, _AvailabilityAge, _ARR, _AccountName, _MonthlyContribution)
        { }
    }
}
