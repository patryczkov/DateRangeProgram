using System;

namespace DateRangeProgram.Views
{
    public class ProgramView
    {
        public void InputLegthError()
        {
            Console.WriteLine("Input is to short, or too long. Check for spaces" +
                "Proper format is dd-MM-yyyy for eu, or MM-dd-yyyy for us" +
                "01-01-0001 as example");
        }
    }
}
