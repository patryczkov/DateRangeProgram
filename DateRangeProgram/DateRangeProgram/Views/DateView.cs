using System;
using System.Collections.Generic;
using System.Text;

namespace DateRangeProgram.Views
{
    public class DateView
    {
        public void WrongDateFormatError(int dateNumericRepresentation)
        {
            Console.WriteLine($"Date nr= {dateNumericRepresentation} format is invalid");
        }
        public void FirstDateIsBiggerError()
        {
            Console.WriteLine("First date is bigger then second one");
        }

        public void PrintResultWithBothYear(string firstDateString, string secondDateString)
        {
            throw new NotImplementedException();
        }
    }
}
