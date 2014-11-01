using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector
{
    static public class ProjectionHelpers
    {
        public static decimal CalculateProjectionAge(DateTime birthDate, DateTime projectionDate)
        {
            decimal projectionAge;
            
            projectionAge = (((projectionDate.Year - birthDate.Year) * 12) + projectionDate.Month - birthDate.Month) / 12;

            return projectionAge;
     
        }
    }
}
