using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using isnet.domain.person;
using isnet.application.person;
using WebAPI.Models;



namespace WebAPI.Controllers
{

    public class PersonsController : ApiController
    {

        PersonServices personServices;
        TestClass testClass;
        
        


        public PersonsController()
        {
            personServices = new PersonServices();
            personServices.createPerson(1, "Andreas", "Grossbauer");
            testClass = new TestClass();
                testClass.Id = 1;
            testClass.Name = "Andreas";
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
       // [HttpGet("{id}", Name="GetPersonById")]
        public TestClass Get(int id)
        {
            //personServices = new PersonServices();
            //personServices.createPerson(1, "Andreas", "Grossbauer");
            //return personServices.findPerson(id);
            return testClass;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Person value)
        {
           // return PersonServices personServices = new PersonServices();
           // personServices.createPerson(1, "Andreas", "Grossbauer");
        }

        // PUT api/values/5

        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
