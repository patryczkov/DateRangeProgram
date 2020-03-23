using System;
using System.Collections.Generic;
using System.Text;

namespace DateRangeProgram.Models
{
    interface IDateValidation
    {
        string DetectCulture();
        bool ValidateDate(string culture);
    }
}
