

namespace DateRangeProgram.Models
{
    public interface IDateParser
    {
        public Date ParseStringIntoDate(string dateString, string culture = "eu");
    }
}
