using DateRangeProgram.Views;

namespace DateRangeProgram
{
    
    public class ProgramController
    {
        private readonly InputValidation _inputValidation;
        private readonly ResultView _resultView;
        private readonly DateController _dateController;

        public ProgramController(InputValidation inputValidation, ResultView resultView ,DateController dateController)
        {
            _inputValidation = inputValidation;
            _resultView = resultView;
            _dateController = dateController;
        }
    }
}