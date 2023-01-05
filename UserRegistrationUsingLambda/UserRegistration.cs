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
        public string ValidateFirstName(string input) =>
             Regex.IsMatch(input, FIRST_NAME_REGEX) ? "Match" : "Not a Match";



    }
}
