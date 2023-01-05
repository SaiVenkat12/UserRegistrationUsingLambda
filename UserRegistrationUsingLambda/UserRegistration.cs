using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingLambda
{
    public class UserRegistration
    {
        public const string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public const string Last_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public string ValidateFirstName(string FName) =>
             Regex.IsMatch(FName, FIRST_NAME_REGEX) ? "First Name is Match" : "Name is Not a Match";
        public string ValidateLastName(string LName) =>
             Regex.IsMatch(LName, Last_NAME_REGEX) ? "Last Name Match" : "Name is Not a Match";



    }
}
