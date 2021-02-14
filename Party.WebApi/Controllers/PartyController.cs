using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using Newtonsoft.Json;
using Party.Core;
using Party.DB;

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
        public IActionResult GetAllWydarzenia()
        {
            string userId = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[3].Value;

            return Ok(_party.GetWydarzenia());
        }
        [HttpGet("{wydarzenieId}",Name = "GetAllUczestnikuwWydarzenia")]
        public IActionResult GetAllUczestnikuwWydarzenia(int wydarzenieId)
        {
            return Ok( _party.GetUczestnikiWydarzenia(wydarzenieId));
        }
        /* [Route("date/{date?}")]
         [HttpGet("{date}", Name = "GetWydarzeniaByDate")]
         public IActionResult GetWydarzeniaByDate(DateTime date)
         {
             return Ok(_party.GetWydarzeniaByDate(date));
         }*/
        [HttpPost(Name = "GetWydarzeniaByDate")]
        public IActionResult CreateWydarzenie(Wydarzenie wydarzenie)
        {
            string userId = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[3].Value;

            return Ok(_party.CreateWydarzenie(wydarzenie, userId));
        }


    }
}
