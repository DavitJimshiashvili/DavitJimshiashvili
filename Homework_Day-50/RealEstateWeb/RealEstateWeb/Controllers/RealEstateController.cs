using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateW.Services.Abstractions;
using RealEstateW.Services.Models;
using RealEstateWeb.Models.DTOs;
using RealEstateWeb.Models.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeb.Controllers
{

    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class RealEstateController : ControllerBase
    {
        private readonly IRealEstateService _service;

        public RealEstateController(IRealEstateService service)
        {
            _service = service;
        }


        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result.Adapt<List<RealEstateDTO>>());
        }

        [HttpGet("filter/range")]
        public async Task<IActionResult> GetRange(double minPrice, double maxPrice)
        {
            var result = await _service.GetRangeAsync(minPrice, maxPrice);
            return Ok(result.Adapt<List<RealEstateDTO>>());
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.GetAsync(id);

            return Ok(result.Adapt<RealEstateDTO>());
        }

        [HttpGet("filter/Code")]
        public async Task<IActionResult> GetBy(string cadastralCode)
        {
            var result = await _service.GetByCodeAsync(cadastralCode);

            return Ok(result.Adapt<RealEstateDTO>());
        }


        [HttpPost]
        public async Task<IActionResult> Post(CreateRealEstateRequest request)
        {
            var serviceModel = request.Adapt<RealEstateServiceModel>();

            var id = await _service.CreateAsync(serviceModel);

            return Ok(id);
        }
        [HttpPut]
        public async Task<IActionResult> Put(PutRealEstateRequest request)
        {
            var serviceModel = request.Adapt<RealEstateServiceModel>();

            var id = await _service.UpdateAsync(serviceModel);

            return Ok(id);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}

