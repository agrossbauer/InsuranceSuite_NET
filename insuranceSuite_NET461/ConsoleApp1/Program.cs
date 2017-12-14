using System;

using isnet.domain.person;
using isnet.application.person;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            PersonServices personServices = new PersonServices();
            personServices.createPerson(1,"Andreas","Grossbauer");
            Console.WriteLine(personServices.findPerson(1).PersonId().ToString());
            Console.ReadKey();
        }
    }
}
