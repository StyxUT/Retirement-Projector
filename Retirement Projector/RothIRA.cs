using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    public class RothIRA : Account
    {
        public RothIRA(double _PreRetirementAccountValue, double _AccountValue, double _AvailabilityAge, double _ARR, string _AccountName, double _MonthlyContribution)
            : base(_AccountValue, _AvailabilityAge, _ARR, _AccountName, _MonthlyContribution)
        { }

        private int preRetirementAccountValue;

        public int PreRetirementAccountValue
        {
            get { return preRetirementAccountValue; }
            private set { preRetirementAccountValue = value; }
        }
    }
}
