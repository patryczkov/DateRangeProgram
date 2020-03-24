using System;
using System.Collections.Generic;
using System.Text;

namespace DateRangeProgram.Models
{
    public interface IDateParser
    {
        public Date ParseStringIntoDate(string dateString);
    }
}
