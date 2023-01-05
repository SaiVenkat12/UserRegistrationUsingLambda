using System;
namespace UserRegistrationUsingLambda
{
    class program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("User Registration Using Lambda");
            Console.Write("Enter The First Name : ");
            string input = Console.ReadLine();
            UserRegistration registration = new UserRegistration();
            Console.WriteLine(registration.ValidateFirstName(input));
           

        }
    }
}