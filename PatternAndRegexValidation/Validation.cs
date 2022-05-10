using System.Text.RegularExpressions;

namespace PatternAndRegexValidation
{
    public class Validation
    {
        public const string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3, }$";
        public const string EMAILADDRESS_REGEX = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public const string EMAILPASSWORD_REGEXX = "[A-Za-z]{8, }$";
        public const string PASSWORDMINIMUMONEUPPERCASE_REGEXX = "[A-Z]{1, }[a-z]{8, }[A-Z]{1, }$";
        public const string PASSWORDMINIMUMONENUMBER_REGEXX = "[A-Z]{1, }[a-z]{8, }[A-Z]{1, }[0-1]{1, }$";
        public const string PASSWORDMINIMUMONE_SPECIALSYMBLE_REGEXX = "[A-Z]{1, }[a-z]{8, }[A-Z]{1, }[0-1]{1, }[!*@#$%^&+=]{1}$";

        public bool Validate_FirstName(string name)
        {
            if (Regex.IsMatch(name, NAME_REGEX)) ;
            {
                Console.WriteLine("First Name is Valid for the user Account:" + name);
                return true;
            }
        }
        public bool Validate_LastName(string last)
        {
            if (Regex.IsMatch(last, NAME_REGEX)) ;
            {
                Console.WriteLine("LastName is Valid for the user Account:" + last);
                return true;
            }
        }
        public bool Validate_EmailAddress(string emailAddress)
        {
            if (Regex.IsMatch(emailAddress, EMAILADDRESS_REGEX)) ;
            {
                Console.WriteLine("Password is Valid for the user Account:" + EMAILADDRESS_REGEX);
                return true;
            }
        }
        public bool Validate_MobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MOBILENUMBER_REGEX)) ;
            {
                Console.WriteLine("Mobile Number is Valid for the user Account:" + mobileNumber);
                return true;
            }
        }
        public bool Validate_EmailPassword(string emailPassword)
        {
            if (Regex.IsMatch(emailPassword, EMAILADDRESS_REGEX)) ;
            {
                Console.WriteLine("Password is Valid for the user Account:" + emailPassword);
                return true;
            }
        }
        public bool Validate_EmailPassword_AtLeastOneUpperCase(string emailPassword)
        {
            if (Regex.IsMatch(emailPassword, PASSWORDMINIMUMONEUPPERCASE_REGEXX)) ;
            {
                Console.WriteLine("Password is Valid for the user Account:" + emailPassword);
                return true;
            }
        }
        public bool Validate_EmailPassword_AtLeastOneNumber(string emailPassword)
        {
            if (Regex.IsMatch(emailPassword, PASSWORDMINIMUMONENUMBER_REGEXX)) ;
            {
                Console.WriteLine("Password is Valid for the user Account:" + emailPassword);
                return true;
            }
        }
        public bool Validate_EmailPassword_OneSpcialCharacter(string emailPassword)
        {
            if (Regex.IsMatch(emailPassword, PASSWORDMINIMUMONE_SPECIALSYMBLE_REGEXX)) ;
            {
                Console.WriteLine("Password is Valid for the user Account:" + emailPassword);
                return true;
            }
        }
    }
}