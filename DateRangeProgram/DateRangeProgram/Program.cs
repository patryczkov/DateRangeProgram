using DateRangeProgram.Models;
using DateRangeProgram.Views;
using System;

namespace DateRangeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debug args parameters
            if (args == null || args[0] == "debug") 
            { 
                args = new string[] { "01.01.2000", "01.02.2000" };
            }

            //views initialization
            var dateView = new DateView();
            var programView = new ProgramView();

            DateValidation dateValidation;
            //models initialization
            var inputValidation = new InputValidation(args);
           
            if(args.Length == 3) 
            {
                dateValidation = new DateValidation(args[2]);
            }
            else
            {
                dateValidation = new DateValidation();
            }

            var dateParser = new DateParser();
            var calculateDateRange = new CalculateDateRange();

            //controller initialization
            var dateController = new DateController(dateValidation, dateParser, calculateDateRange, dateView);
            var programController = new ProgramController(inputValidation, programView, dateController, args);


            //Program turn on
            programController.RunProgram();
        }
    }
}
