using DateRangeProgram.Models;
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
            Console.WriteLine($"{firstDateString} - {secondDateString}");
        }
        //TODO change formating of 01, 03 ect. intigers
        public void PrintResultWithBothMonth(Date firstDate, string secondDateString)
        {
            Console.WriteLine($"{firstDate.Day}.{firstDate.Month} - {secondDateString}");
        }

        public void PrintResultWithBothDay(Date firstDate, string secondDateString)
        {
            Console.WriteLine($"{firstDate.Day} - {secondDateString}");
        }
    }
}
