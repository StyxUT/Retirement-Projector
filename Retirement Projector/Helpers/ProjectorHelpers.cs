using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementProjector.Helpers
{
    static class ProjectionHelpers
    {
        public static decimal CalculateProjectionAge(DateTime birthDate, DateTime projectionDate)
        {

            //DateTime today = DateTime.Today;
            //int age = today.Year - bday.Year;
            //if (bday > today.AddYears(-age)) age--;

            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = projectionDate - birthDate;

            decimal years = (zeroTime + span.tot) - 1;
            return years;
        }
    }
}
