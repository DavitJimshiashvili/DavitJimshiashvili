using Mapster;
using Microsoft.AspNetCore.Mvc;
using PersonManagement.Services.Abstractions;
using PersonManagement.Services.Models;
using PersonManagement.Web.Infrastracture.Localizations;
using PersonManagement.Web.Models;
using PersonManagement.Web.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagement.Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();

            var personDTOResult = result.Adapt<List<PersonDTO>>();


            return Ok(personDTOResult);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.GetAsync(id);
            if (result == null)
                return NotFound(ErrorMessages.NotFound);

            var personDTOResult = result.Adapt<PersonDTO>();

            return Ok(personDTOResult);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePersonRequest createRequest)
        {
            var person = createRequest.Adapt<PersonServiceModel>();

            var id = await _service.CreateAsync(person);

            return Ok(id);
        }
    }
}
