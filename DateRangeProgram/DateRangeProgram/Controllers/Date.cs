namespace DateRangeProgram.Models
{
    public class Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
}
