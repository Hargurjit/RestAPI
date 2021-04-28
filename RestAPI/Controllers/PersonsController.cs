using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using RestAPI.PersonData;
using System;

namespace RestAPI.Controllers
{
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonData _personData;
        public PersonsController(IPersonData personData)
        {
            _personData = personData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetPersons()
        {
            return Ok(_personData.GetPersons());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetPerson(Guid id)
        {
            var person = _personData.GetPerson(id);
            if (person != null) return Ok(_personData.GetPerson(id));
            else return NotFound($"Person with ID {id} could not be found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetPerson(Person person)
        {
            _personData.AddPerson(person);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + person.Id, person);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeletePerson(Guid id)
        {
            var person = _personData.GetPerson(id);
            if (person != null) { 
                _personData.DeletePerson(person);
                return Ok();
            }
            else return NotFound($"Person with ID {id} could not be found");
        }
    }

}
