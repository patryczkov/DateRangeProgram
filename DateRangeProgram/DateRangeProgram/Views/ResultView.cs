using System;
using System.Collections.Generic;
using System.Text;

namespace DateRangeProgram.Views
{
    public class ResultView
    {
        public void PrintWrongDateFormat(int dateNumericRepresentation)
        {
            Console.WriteLine($"Date nr= {dateNumericRepresentation} format is invalid");
        }
    }
}
