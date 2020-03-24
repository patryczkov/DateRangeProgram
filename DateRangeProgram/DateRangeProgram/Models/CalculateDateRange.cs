using System;
using System.Collections.Generic;
using System.Text;

namespace DateRangeProgram.Models
{
    public class CalculateDateRange : ICalculateDateRange
    {
        public string[] CalulateDiffrenceBetweenDates(Date firstDate, Date secondDate)
        {
            throw new NotImplementedException();
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
