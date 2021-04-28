using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.PersonData
{
    public class SqlPersonData : IPersonData
    {
        private PersonContext _personcontext;
        public SqlPersonData(PersonContext personContext)
        {
            _personcontext = personContext;
        }
        public void AddPerson(Person person)
        {
            person.Id = Guid.NewGuid();
            person.DisplayName = $"{person.FirstName} {person.LastName}";
            _personcontext.People.Add(person);
            _personcontext.SaveChanges();
        }

        public void DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person EditPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(Guid id)
        {
            var person = _personcontext.People.Find(id);
            return person;
        }

        public List<Person> GetPersons()
        {
            return _personcontext.People.ToList();
        }
    }
}
