using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Party.WebApi.Controllers
{
    public class PartyController : BaseController
    {

        private readonly ILogger<PartyController> _logger;

        public PartyController(ILogger<PartyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var t = User.Identity!.Name;
            var tt = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList();
            return Ok("Note");
        }

    }
}
