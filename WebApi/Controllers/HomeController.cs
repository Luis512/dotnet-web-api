using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private List<Person> people = new List<Person>()
        {
            new Person()
            {
                Name = "Luis",
                Age = 28
            },
            new Person()
            {
                Name = "Marco",
                Age = 26
            }
        };

        [HttpGet]
        public List<Person> GetPeople()
        {
            return people;
        }

        [HttpGet]
        [Route("{name}")]
        public Person GetPerson(string name)
        {
            return people.FirstOrDefault(p => p.Name.Equals(name));
        }

    }
}
