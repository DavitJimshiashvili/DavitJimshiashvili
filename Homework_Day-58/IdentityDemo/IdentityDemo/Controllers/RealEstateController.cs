using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Controllers
{
    [Authorize(Roles = "Admin")]

    public class RealEstateController : Controller
    {
        private readonly IRealEstateReopsitory _realEstateRepository;

        public RealEstateController(IRealEstateReopsitory realEstateRepository)
        {
            _realEstateRepository = realEstateRepository;
        }

        public async Task<IActionResult> List()
        {
            var result = await _realEstateRepository.GetAllAsync();
         
            return View(result);
        }
        public async Task<IActionResult> Details(int id)
        {
            var result = await _realEstateRepository.GetAllAsync();

            var property = result.FirstOrDefault(x => x.Id == id);

            if (property == null)
                return NotFound();

            return View(property);

        }
    }
}
