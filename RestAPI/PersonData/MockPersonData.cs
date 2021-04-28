using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI.PersonData
{
    
    public class MockPersonData : IPersonData
    {
        private List<Person> persons = new List<Person>()
    {
        new Person
        {
            Id = Guid.NewGuid(),
            FirstName = "1",
            LastName = "A",
            DisplayName = "a"
        },
        new Person
        {
            Id = Guid.NewGuid(),
            FirstName = "2",
            LastName = "B",
            DisplayName = "b"
        }
    };

        public void AddPerson(Person person)
        {
            person.Id = Guid.NewGuid();
            person.DisplayName = $"{person.FirstName} {person.LastName}";
            persons.Add(person);
        }

        public void DeletePerson(Person person)
        {
            persons.Remove(person);
        }

        public Person EditPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(Guid id)
        {
            return persons.SingleOrDefault(x => id == x.Id);
        }

        public List<Person> GetPersons()
        {
            return persons;
        }
    }
}
