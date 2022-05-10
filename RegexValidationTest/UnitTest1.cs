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
        public void InputInString_Test_LastNameOfUser()
        {
            Validation input = new Validation();
            bool result = input.Validate_FirstName("Kumar");
            Assert.IsTrue(result);
        }
        [Test]
        public void InputInString_EmailAddressOfUser()
        {
            Validation input = new Validation();
            bool result = input.Validate_EmailAddress("vinaykumar123@gmail.com");
            Assert.IsTrue(result);
        }
        [Test]
        public void InputInString_TestMobileNumberLOfUser()
        {
            Validation input = new Validation();
            bool result = input.Validate_MobileNumber("+91 70810209335");
            Assert.IsTrue(result);
        }
        [Test]
        public void InputInString_PasswordOfEmailAddressOfUser()
        {
            Validation input = new Validation();
            bool result = input.Validate_EmailPassword("Helloworld");
            Assert.IsTrue(result);
        }
        public void InputInString_PasswordOfEmailAddressOfUser_AtLeastOne_UpperCase()
        {
            Validation input = new Validation();
            bool result = input.Validate_EmailPassword_AtLeastOneUpperCase("HellOWorld");
            Assert.IsTrue(result);
        }
        public void InputInString_PasswordOfEmailAddressOfUser_AtLeastOne_Number()
        {
            Validation input = new Validation();
            bool result = input.Validate_EmailPassword_AtLeastOneNumber("HellOWorld");
            Assert.IsTrue(result);
        }
        public void InputInString_PasswordOfEmailAddressOfUser_OneSpecialCharacter()
        {
            Validation input = new Validation();
            bool result = input.Validate_EmailPassword_OneSpcialCharacter("HellO&World");
            Assert.IsTrue(result);
        }
    }
}