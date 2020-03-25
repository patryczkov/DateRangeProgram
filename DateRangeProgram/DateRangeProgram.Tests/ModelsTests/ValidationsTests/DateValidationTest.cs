using DateRangeProgram.Models;
using NUnit.Framework;


namespace DateRangeProgram.Tests.ModelsTests.ValidationsTests
{
    [TestFixture]
    public class DateValidationTest
    {
        [Test]
        public void CheckIfDateIsValidFor_USCulture()
        {
            //arrange
            var testDateUS = "12.21.2010";
            var culture = "us";
            var dateValidation = new DateValidation(culture);

            //act
            var result = dateValidation.ValidateDate(testDateUS);

            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckIfDateIsValidFor_EUCulture()
        {
            //arrange
            var testDateUS = "20.12.2010";
            var culture = "eu";
            var dateValidation = new DateValidation(culture);

            //act
            var result = dateValidation.ValidateDate(testDateUS);

            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckIfDateIsInvalidFor_USCulture()
        {
            //arrange
            var testDateUS = "20.02.2010";
            var culture = "us";
            var dateValidation = new DateValidation(culture);

            //act
            var result = dateValidation.ValidateDate(testDateUS);

            //assert
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckIfDateIsInvalidFor_EUCulture()
        {
            //arrange
            var testDateUS = "12.20.2010";
            var culture = "eu";
            var dateValidation = new DateValidation(culture);

            //act
            var result = dateValidation.ValidateDate(testDateUS);

            //assert
            Assert.IsFalse(result);
        }

    }
}
