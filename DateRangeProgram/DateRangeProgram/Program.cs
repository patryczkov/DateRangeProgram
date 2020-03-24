using DateRangeProgram.Models;
using DateRangeProgram.Views;

namespace DateRangeProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            var testArgs = new string[] { "01.01.2000", "01.02.2000" };

            //views initialization
            var dateView = new DateView();
            var programView = new ProgramView();

            //models initialization
            var inputValidation = new InputValidation(testArgs);
           
            var dateValidation = new DateValidation();
            var dateParser = new DateParser();
            var calculateDateRange = new CalculateDateRange();

            //controller initialization
            var dateController = new DateController(dateValidation, dateParser, calculateDateRange, dateView);
            var programController = new ProgramController(inputValidation, programView, dateController, testArgs);


            //Program turn on
            programController.RunProgram();



         
  
        }
    }
}
