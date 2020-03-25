using DateRangeProgram.Models;
using NUnit.Framework;


namespace DateRangeProgram.Tests.ModelsTests
{
    [TestFixture]
    public class CalculateDateRangeTest
    {
        public CalculateDateRange calculateDateRange;


        [SetUp]
        public void SetupClass()
        {
            calculateDateRange = new CalculateDateRange();
        }
        
        [Test]
        public void CheckIfFirstDateIs_Smaller_ThanSecondDate()
        {
            //arrange
            var firstDate = new Date(01,01,2000);
            var secondDate = new Date(02,01,2000);

            //act
            var result = calculateDateRange.CheckIfFirstDateIsSmallerThansSecondOne(firstDate, secondDate);
            
            //assert
            Assert.IsTrue(result);
        }
   



    }
}
