using Mapster;
using Microsoft.AspNetCore.Mvc;
using RealEstateW.Services.Abstractions;
using RealEstateW.Services.Models;
using RealEstateWeb.Models.Requests.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _service;

        public AccountController(IUserService service)
        {
            _service = service;
        }
        [Route("Register")]
        [HttpPost]
        public async Task<IActionResult> Register(CreateAccountRequest request)
        {
            var result = await _service.CreateAsync(request.Adapt<UserServiceModel>());

            return Ok(result);
        }

        [Route("LogIn")]
        [HttpPost]
        public async Task<IActionResult> LogIn(AccountLogginRequest request)
        {
            var token = await _service.AuthenticateAsync(request.Username, request.Password);

            return Ok(token);
        }
    }
}
