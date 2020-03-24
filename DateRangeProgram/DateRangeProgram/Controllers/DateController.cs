using DateRangeProgram.Models;
using DateRangeProgram.Views;

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
        private readonly ResultView _resultView;

        public DateController(IDateValidation dateValidation, IDateParser dateParser, ICalculateDateRange calculateDateRange, ResultView resultView)
        {
            _dateValidation = dateValidation;
            _dateParser = dateParser;
            _calculateDateRange = calculateDateRange;
            _resultView = resultView;
        }
        
        public void GetDatesRange(string firstDateString, string secondDateString)
        {
            var checkStatus = CheckIfDatesAreProper(firstDateString, secondDateString);
            if (checkStatus != 0)
            {
                _resultView.PrintWrongDateFormat(checkStatus);
                return;
            }

            var firstDate = _dateParser.ParseStringIntoDate(firstDateString);
            var secondDate = _dateParser.ParseStringIntoDate(secondDateString);




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