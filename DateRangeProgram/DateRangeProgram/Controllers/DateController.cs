using DateRangeProgram.Models;
using DateRangeProgram.Views;

namespace DateRangeProgram
{
    public class DateController
    {
        private enum NumericRepresentation
        {
            firstDate = 1,
            secondDate = 2,
            properDate = 0
        }
        private enum Index 
        {
            day = 0,
            month = 1,
            year = 2
        }

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
            if (checkStatus != (int)NumericRepresentation.properDate)
            {
                _view.WrongDateFormatError(checkStatus);
                return;
            }
            //stage 2nd - check if first date is smaller than second one
            var firstDate = _dateParser.ParseStringIntoDate(firstDateString, culture);
            var secondDate = _dateParser.ParseStringIntoDate(secondDateString, culture);

            if (!_calculateDateRange.CheckIfFirstDateIsSmallerThansSecondOne(firstDate, secondDate))
            {
                _view.FirstDateIsBiggerError();
                return;
            }
            //stage 3rd - prepare result by printing it
            PrepareResults(firstDate, secondDate);

        }
        private void PrepareResults(Date firstDate, Date secondDate)
        {
            var datesDiffrenceArray = _calculateDateRange.CalulateDiffrenceBetweenDates(firstDate, secondDate);

            if (datesDiffrenceArray[(int)Index.year] != 0)
            {
                _view.PrintResultWithBothYear(firstDate, secondDate);
            }
            else
            {
                if (datesDiffrenceArray[(int)Index.month] != 0)
                {
                    _view.PrintResultWithBothMonth(firstDate, secondDate);
                }
                else
                {
                    _view.PrintResultWithBothDay(firstDate, secondDate);
                }
            }
        }
        //it points which date is incorrect so it can send proper message to user
        private int CheckIfDatesAreProper(string firstDateString, string secondDateString)
        {
            if (!_dateValidation.ValidateDate(firstDateString)) return  (int)NumericRepresentation.firstDate;
            if (!_dateValidation.ValidateDate(secondDateString)) return (int)NumericRepresentation.secondDate;
            return (int)NumericRepresentation.properDate;
        }

    }
}