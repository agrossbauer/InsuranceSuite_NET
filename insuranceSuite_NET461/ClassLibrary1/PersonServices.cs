using System;
using isnet.domain.person;
using System.Collections.Generic;

namespace isnet.application.person
{
    public class PersonServices
    {
        private PersonRepository personRepository;


        public PersonServices()
        {
            personRepository = new PersonRepository();
        }


        public void createPerson(int aId, String aFirstName, String aLastName)
        {
            Person person = new Person();
            person.CreatePerson(aId,aFirstName,aLastName);
            personRepository.Add(person);
        }

        public Person findPerson(int aId)
        {
            return personRepository.PersonOfId(aId);
        }



    }

    public class PersonRepository : IPersonRepository
    {

        private readonly Dictionary<int, Person> dictRepository;

        public PersonRepository()
        {
            dictRepository = new Dictionary<int, Person>();
        }

        public void Add(Person aPerson)
        {
            dictRepository.Add(aPerson.PersonId(),aPerson);
        }

        public void Delete(Person aPerson)
        {
            dictRepository.Remove(aPerson.PersonId());
        }


        public IEnumerable<Person> FindAll()
        {
            return dictRepository.Values;
        }


        public Person PersonOfId(int aPersonId)
        {
            return dictRepository[aPersonId];
        }

    }
}
