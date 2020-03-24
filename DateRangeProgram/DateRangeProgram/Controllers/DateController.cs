using DateRangeProgram.Models;
using DateRangeProgram.Views;

namespace DateRangeProgram
{
    public class DateController
    {
        private const int FIRST_DATE_NUMERIC_REPRESENTATION = 1;
        private const int SECOND_DATE_NUMERIC_REPRESENTATION = 2;
        private const int PROPER_DATES_NUMERIC_REPRESENTATION = 0;

        private const int DAY_INDEX = 0;
        private const int MONTH_INDEX = 1;
        private const int YEAR_INDEX = 2;

        private readonly IDateValidation _dateValidation;
        private readonly IDateParser _dateParser;
        private readonly ICalculateDateRange _calculateDateRange;
        private readonly DateView _view;

        public DateController(IDateValidation dateValidation, IDateParser dateParser, ICalculateDateRange calculateDateRange, DateView view)
        {
            _dateValidation = dateValidation;
            _dateParser = dateParser;
            _calculateDateRange = calculateDateRange;
            _view = view;
        }
        
        public void GetDatesRange(string firstDateString, string secondDateString, string culture = "eu")
        {
            //stage 1st - Check if dateFormats are proper
            var checkStatus = CheckIfDatesAreProper(firstDateString, secondDateString);
            if (checkStatus != PROPER_DATES_NUMERIC_REPRESENTATION)
            {
                _view.WrongDateFormatError(checkStatus);
                return;
            }
            //stage 2nd - check if first date is smaller than second one
            var firstDate = _dateParser.ParseStringIntoDate(firstDateString, culture);
            var secondDate = _dateParser.ParseStringIntoDate(secondDateString, culture);

            if (_calculateDateRange.CheckIfFirstDateIsSmallerThansSecondOne(firstDate, secondDate))
            {
                _view.FirstDateIsBiggerError();
                return;
            }
            //stage 3rd - prepare result by printing it
            PrepareResults(firstDateString, secondDateString, firstDate, secondDate);

        }
        //TODO check if return are nesessery to valid running of program
        private void PrepareResults(string firstDateString, string secondDateString, Date firstDate, Date secondDate)
        {
            var datesDiffrenceArray = _calculateDateRange.CalulateDiffrenceBetweenDates(firstDate, secondDate);

            if (datesDiffrenceArray[YEAR_INDEX] != 0)
            {
                _view.PrintResultWithBothYear(firstDateString, secondDateString);
                return;
            }
            else
            {
                if (datesDiffrenceArray[MONTH_INDEX] != 0)
                {
                    _view.PrintResultWithBothMonth(firstDate, secondDateString);
                    return;
                }
                else
                {
                    _view.PrintResultWithBothDay(firstDate, secondDateString);
                    return;
                }
            }
        }

        //it points which date is incorrect so it can send proper message to user
        private int CheckIfDatesAreProper(string firstDateString, string secondDateString)
        {
            if (!_dateValidation.ValidateDate(firstDateString)) return FIRST_DATE_NUMERIC_REPRESENTATION;
            if (!_dateValidation.ValidateDate(secondDateString)) return SECOND_DATE_NUMERIC_REPRESENTATION;
            return PROPER_DATES_NUMERIC_REPRESENTATION;
        }

    }
}