

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
                return new Date(int.Parse(splittedDate[_DAY_INDEX_EU]),
                int.Parse(splittedDate[_MONTH_INDEX_EU]),
                int.Parse(splittedDate[_YEAR_INDEX]));
            }
            else
            {
                return new Date(int.Parse(splittedDate[_DAY_INDEX_US]),
                int.Parse(splittedDate[_MONTH_INDEX_US]),
                int.Parse(splittedDate[_YEAR_INDEX]));
            }
        }
    }
}
