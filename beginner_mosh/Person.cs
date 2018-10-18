using System;

namespace CSharpFundamentals
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public void setFirstName(string firstNameIn)
        {
            firstName = firstNameIn;
        }
        public void setLastName(string lastNameIn)
        {
            lastName = lastNameIn;
        }
        public void introDuce()
        {
            Console.WriteLine("Hi my name is " + firstName + " " + lastName);
        }
    }
}
