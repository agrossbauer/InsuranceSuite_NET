using System;
using System.Collections.Generic;

namespace isnet.domain.person
{
    public class Person
    {
        private int id;
        private String firstName;
        private String lastName;

        public void CreatePerson(int aId, String aFirstName, String aLastName)
        {
            id = aId;
            firstName = aFirstName;
            lastName = aLastName;
        }

        public int PersonId()
        {
            return id;
        }
    }


    


    public interface IPersonRepository
    {
        void Add(Person aPerson);
        void Delete(Person aPerson);
        Person PersonOfId(int aPersonId);
        IEnumerable<Person> FindAll();

    }

}
