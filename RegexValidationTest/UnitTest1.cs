using NUnit.Framework;
using PatternAndRegexValidation;

namespace RegexValidationTest
{
    public class Tests
    {
       
        [Test]
        public void InputInString_Test_FirstNameOfUser()
        {
            Validation input = new Validation();
            bool result = input.Validate_FirstName("Vinay");
            Assert.IsTrue(result);
        }

    }
}