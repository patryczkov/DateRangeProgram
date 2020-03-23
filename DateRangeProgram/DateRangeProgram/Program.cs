using DateRangeProgram.Views;

namespace DateRangeProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            //Initialize all classes and injecting them into main program controller
            var inputValidation = new InputValidation(args);

            var resultView = new ResultView();

            var dateController = new DateController();

            var programController = new ProgramController(inputValidation, resultView, dateController);
  
        }
    }
}
