using System;
using System.Collections.Generic;
using System.Text;

namespace DateRangeProgram.Models
{
    public class CalculateDateRange : ICalculateDateRange
    {
        public int[] CalulateDiffrenceBetweenDates(Date firstDate, Date secondDate)
        {
            var yearDiffrence = firstDate.Year - secondDate.Year;
            var monthDiffrence = firstDate.Month - secondDate.Month;
            var dayDiffrence = firstDate.Day - secondDate.Day;

            return new int[] { dayDiffrence, monthDiffrence, yearDiffrence };
        }

        public bool CheckIfFirstDateIsSmallerThansSecondOne(Date firstDate, Date secondDate)
        {
            if (firstDate.Year < secondDate.Year) return true;
           
            if (firstDate.Year == secondDate.Year)
            {
                if (firstDate.Month < secondDate.Month) return true;

                if (firstDate.Month == secondDate.Month) return firstDate.Day < secondDate.Day;

                return false;
            }         
            return false;
        }
    }
}
