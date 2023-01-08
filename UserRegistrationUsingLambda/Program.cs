using System;
namespace UserRegistrationUsingLambda
{
    class program
    {
        public static void Main(string[]args)
        {
            //Console.WriteLine("User Registration Using Lambda");
            //Console.Write("Enter The First Name : ");
            //string FName = Console.ReadLine();
            //Console.Write("Enter The Last Name : ");
            //string LName = Console.ReadLine();
            //Console.Write("Enter the Email Address : ");
            //string Email = Console.ReadLine();
            //Console.Write("Enter the Mobile Number : ");
            //string MobileNo = Console.ReadLine();
            //Console.Write("Enter the Password : ");
            //string Password = Console.ReadLine();
            string email = "Abc1@gmail.com";
            string email2 = "abc+100@gmail.com";
            string email3 = "abc-100@abc.net,";

            UserRegistration registration = new UserRegistration();
            //Console.WriteLine(registration.ValidateFirstName(FName));
            //Console.WriteLine(registration.ValidateLastName(LName));
            //Console.WriteLine(registration.ValidateEMail(Email));
            //Console.WriteLine(registration.ValidateMobileNo(MobileNo));
            //Console.WriteLine(registration.ValidatePassword(Password));
            Console.WriteLine(registration.ValidateEMail(email));
            Console.WriteLine(registration.ValidateEMail(email2));
            Console.WriteLine(registration.ValidateEMail(email3));


        }
    }
}