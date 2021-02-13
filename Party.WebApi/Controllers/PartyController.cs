using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using Newtonsoft.Json;
using Party.Core;

namespace Party.WebApi.Controllers
{
    public class PartyController : BaseController
    {

        private readonly ILogger<PartyController> _logger;
        private readonly IPartyService _party;

        public PartyController(ILogger<PartyController> logger, IPartyService party)
        {
            _logger = logger;
            _party = party;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string userId = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[3].Value;
           
            return Ok(_party.GetWydarzenia());
        }

    }
}
