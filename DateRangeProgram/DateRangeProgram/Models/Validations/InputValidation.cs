using DateRangeProgram.Models;

namespace DateRangeProgram
{
    public class InputValidation : IInputValidation
    {
        private string[] _args;

        public InputValidation(string[] args)
        {
            _args = args;
        }

        public bool ValidateInputLength()
        {
            if (_args.Length == 2 || _args.Length == 3)
            {
                return true;
            }
            return false;
        }
    }
}