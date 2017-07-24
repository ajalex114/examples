using System;
using TuplesLib;
using Xunit;

namespace Tuples.Test
{
    public class PersonTest
    {
        private Person _person;

        public PersonTest()
        {
            _person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 20,
                EmailId = "john.doe@example.com"                
            };
        }

        [Fact]
        public void TestCreatePerson()
        {
            Assert.Equal("John", _person.FirstName);
            Assert.Equal("Doe", _person.LastName);
            Assert.Equal(20, _person.Age);
            Assert.Equal("john.doe@example.com", _person.EmailId);            
        }

        [Fact]
        public void TupleTest()
        {
            var names = _person.GetName();

            Assert.Equal("John", names.firstName);
            Assert.Equal("Doe", names.lastName);
        }

        [Fact]
        public void DeconstructTupleTestWithFirstAndLastNameTest()
        {
            (var firstName, var lastName) = _person;

            Assert.Equal("John", firstName);
            Assert.Equal("Doe", lastName);
        }
        
        [Fact]
        public void DeconstructTupleTestWithFirst_LastNameAndAgeTest()
        {
            (var firstName, var lastName, var age) = _person;

            Assert.Equal("John", firstName);
            Assert.Equal("Doe", lastName);
            Assert.Equal(20, age);
        }
    }
}
