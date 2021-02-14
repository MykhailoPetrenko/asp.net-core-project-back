using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Party.Core;
using Party.DB;

namespace Party.WebApi.Controllers
{
    public class UserController: BaseController
    {
        private readonly ILogger<PartyController> _logger;
        private readonly IUserServises _user;

        public UserController(ILogger<PartyController> logger, IUserServises user)
        {
            _logger = logger;
            _user = user;
        }
        [HttpPost(Name = "RegisterUser")]
        public IActionResult RegisterUser()
        {
            var user = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList();
            string userId = user[3].Value;
            string email = user[9].Value;

            return Ok(_user.RegisterUczestnik(userId, userId));
        }
    }
}
