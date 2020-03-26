using NUnit.Framework;

namespace DateRangeProgram.Tests.ModelsTests.ValidationsTests
{
    [TestFixture]
    public class InputValidationTest
    {
      
        [Test]
        public void CheckIfMethodReturn_True_ForArgsLenght_3()
        {
            //arrange
            var testArgs = new string[] { "test", "test", "test" };
            InputValidation inputValidation = new InputValidation(testArgs);

            //act
            bool result = inputValidation.ValidateInputLength();
            
            //assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckIfMethodReturn_False_ForArgsLenght_1()
        {
            //arrange
            var testArgs = new string[] { "test" };
            InputValidation inputValidation = new InputValidation(testArgs);

            //act
            bool result = inputValidation.ValidateInputLength();

            //assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckIfMethodReturn_False_ForArgs_null()
        {
            //arrange
            var testArgs = new string[] {null};
            InputValidation inputValidation = new InputValidation(testArgs);

            //act
            bool result = inputValidation.ValidateInputLength();

            //assert
            Assert.IsFalse(result);
        }

    }
}
