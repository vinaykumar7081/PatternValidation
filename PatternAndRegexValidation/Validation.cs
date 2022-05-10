using System.Text.RegularExpressions;

namespace PatternAndRegexValidation
{
    public class Validation
    {
        public const string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3, }$";
        public const string EMAILADDRESS_REGEX = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$";
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
       
    }
}