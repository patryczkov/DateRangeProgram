using System;
using System.Collections.Generic;
using System.Text;

namespace DateRangeProgram.Models
{
    public class DateParser : IDateParser
    {
        private const int _DAY_INDEX_EU = 0;
        private const int _MONTH_INDEX_EU = 1;

        private const int _DAY_INDEX_US = 1;
        private const int _MONTH_INDEX_US = 0;

        private const int _YEAR_INDEX = 2;
        public Date ParseStringIntoDate(string dateString, string culture = "eu")
        {
            var splittedDate = dateString.Split(".");
            if (culture == "eu")
            {
                return new Date(splittedDate[_DAY_INDEX_EU],
                splittedDate[_MONTH_INDEX_EU],
                splittedDate[_YEAR_INDEX]);
            }
            else
            {
                return new Date(splittedDate[_DAY_INDEX_US],
                splittedDate[_MONTH_INDEX_US],
                splittedDate[_YEAR_INDEX]);
            }
        }
    }
}
