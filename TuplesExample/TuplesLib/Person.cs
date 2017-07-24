using System;

namespace TuplesLib
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string EmailId { get; set; }

        public (string firstName, string lastName) GetName() => (FirstName, LastName);

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            Deconstruct(out firstName, out lastName);
            age = Age;
        }
    }
}
