using DateRangeProgram.Models;

namespace DateRangeProgram
{
    public class DateController
    {
        private const int FIRST_DATE_NUMERIC_REPRESENTATION = 1;
        private const int SECOND_DATE_NUMERIC_REPRESENTATION = 2;
        private const int PROPER_DATES_NUMERIC_REPRESENTATION = 0;

        private readonly IDateValidation _dateValidation;
        private readonly IDateParser _dateParser;
        private readonly ICalculateDateRange _calculateDateRange;

        public DateController(IDateValidation dateValidation, IDateParser dateParser, ICalculateDateRange calculateDateRange)
        {
            _dateValidation = dateValidation;
            _dateParser = dateParser;
            _calculateDateRange = calculateDateRange;
        }
        //it points which date is incorrect so it can send proper message to user
        public int CheckIfDatesAreProper(string firstDateString, string secondDateString)
        {
            if (!_dateValidation.ValidateDate(firstDateString)) return FIRST_DATE_NUMERIC_REPRESENTATION;
            if (!_dateValidation.ValidateDate(secondDateString)) return SECOND_DATE_NUMERIC_REPRESENTATION;
            return PROPER_DATES_NUMERIC_REPRESENTATION;
        }


    }
}