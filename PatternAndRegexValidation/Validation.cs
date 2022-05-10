﻿using System.Text.RegularExpressions;

namespace PatternAndRegexValidation
{
    public class Validation
    {
        public const string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3, }$";
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
    }
}