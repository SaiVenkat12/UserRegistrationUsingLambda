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
        public const string MobileNO = "^[0-9]{2}[ ]*[6-9]{1}[0-9]{9}$";
        public const string EMail = "^[a-zA-Z0-9]([.+-_]{0,1}[a-zA-z0-9]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,}([.]{0,1}[A-Za-z]{2,}?([.]{0,1}[A-Za-z]{2,}))*[,]{0,1}$";
        public const string PassWord = "(?=.*[A-Z])(?=.*[0-9])(?=.*[.,/+_@!#$%&*]).{8,}$";
        public string ValidateFirstName(string FName) =>
             Regex.IsMatch(FName, FIRST_NAME_REGEX) ? "First Name is a Match" : "Name is Not a Match";
        public string ValidateLastName(string LName) =>
             Regex.IsMatch(LName, Last_NAME_REGEX) ? "Last Name is a Match" : "Name is Not a Match";
        public string ValidateEMail(string Email) =>
             Regex.IsMatch(Email, EMail) ? "EMail is Match" : "Email Not a Match";
        public string ValidateMobileNo(string MobileNo) =>
             Regex.IsMatch(MobileNo, MobileNO) ? "Mobile Number is a Match" : "Mobile Number Not a Match";
        public string ValidatePassword(string Password) =>
             Regex.IsMatch(Password, PassWord) ? "Password is a Match" : "Password Not a Match";


    }
}
