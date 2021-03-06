﻿using DateRangeProgram.Views;

namespace DateRangeProgram
{

    public class ProgramController
    {
        private enum Index
        {
            firstDate = 0,
            secondDate = 1,
            culture = 2
        }
        private enum ArgsLegth
        {
            lenghtOfArgsWithOutCulture = 2,
            lenghtOfArgsWithCulture = 3
        }


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
            if (args.Length >= (int)ArgsLegth.lenghtOfArgsWithOutCulture)
            {
                _firstDateString = args[(int)Index.firstDate];
                _secondDateString = args[(int)Index.secondDate];
            }
            if (args.Length == (int)ArgsLegth.lenghtOfArgsWithCulture)
            {
                _culture = args[(int)Index.culture];
            }
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