using System;
namespace UserRegistrationUsingLambda
{
    class program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("User Registration Using Lambda");
            Console.Write("Enter The First Name : ");
            string FName = Console.ReadLine();
            Console.Write("Enter The Lastt Name : ");
            string LName = Console.ReadLine();
            UserRegistration registration = new UserRegistration();
            Console.WriteLine(registration.ValidateFirstName(FName));
            Console.WriteLine(registration.ValidateLastName(LName));


        }
    }
}