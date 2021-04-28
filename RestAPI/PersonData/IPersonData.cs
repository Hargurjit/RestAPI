using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.PersonData
{
    public interface IPersonData
    {
        List<Person> GetPersons();

        Person GetPerson(Guid id);

        void AddPerson(Person person);

        void DeletePerson(Person person);

        Person EditPerson(Person person);
    }
}
