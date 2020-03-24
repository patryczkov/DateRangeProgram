using DateRangeProgram.Views;

namespace DateRangeProgram
{

    public class ProgramController
    {
        private const int FIRST_DATE_INDEX = 0;
        private const int SECOND_DATE_INDEX = 1;
        private const int CULTURE_INDEX = 2;

        private readonly string _firstDateString;
        private readonly string _secondDateString;
        private readonly string _culture;


        private readonly InputValidation _inputValidation;
        private readonly ProgramView _view;
        private readonly DateController _dateController;


        public ProgramController(InputValidation inputValidation, ProgramView view, DateController dateController, string[] args)
        {
            _inputValidation = inputValidation;
            _view = view;
            _dateController = dateController;
            _firstDateString = args[FIRST_DATE_INDEX];
            _secondDateString = args[SECOND_DATE_INDEX];
            if (args.Length == 3) _culture = args[CULTURE_INDEX];
        }

        public void RunProgram()
        {
            if (!_inputValidation.ValidateInputLength())
            {
                _view.InputLegthError();
                return;
            }
            
            if (_culture != null) 
            {
                _dateController.GetDatesRange(_firstDateString, _secondDateString, _culture); 
            }
            else
            {
                _dateController.GetDatesRange(_firstDateString, _secondDateString);
            }



        }



    }
}