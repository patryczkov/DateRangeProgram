using System;
using System.Collections.Generic;
using System.Text;

namespace DateRangeProgram.Models
{
    public interface ICalculateDateRange
    {
        public bool CheckIfFirstDateIsSmallerThansSecondOne(Date firstDate, Date secondDate);
        public string[] CalulateDiffrenceBetweenDates(Date firstDate, Date secondDate);
    }
}
