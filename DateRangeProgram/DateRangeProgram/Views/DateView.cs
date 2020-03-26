using DateRangeProgram.Models;
using System;

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

        public void PrintResultWithBothYear(Date firstDate, Date secondDate)
        {
            Console.WriteLine($"{firstDate.Day:D2}.{firstDate.Month:D2}.{firstDate.Year:D4} " +
                $"- {secondDate.Day:D2}.{secondDate.Month:D2}.{secondDate.Year:D4}");
        }

        public void PrintResultWithBothMonth(Date firstDate, Date secondDate)
        {
            Console.WriteLine($"{firstDate.Day:D2}.{firstDate.Month:D2}" +
                $" - {secondDate.Day:D2}.{secondDate.Month:D2}.{secondDate.Year:D4}");
        }

        public void PrintResultWithBothDay(Date firstDate, Date secondDate)
        {
            Console.WriteLine($"{firstDate.Day:D2} " +
                $" - {secondDate.Day:D2}.{secondDate.Month:D2}.{secondDate.Year:D4}");
        }
    }
}
