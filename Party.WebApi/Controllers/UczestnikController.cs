using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Party.Core;
using Party.DB;

namespace Party.WebApi.Controllers
{
    public class UczestnikController: BaseController
    {
        private readonly IUczestnikServices _uczestnik;

        public UczestnikController(IUczestnikServices uczestnik)
        {
            _uczestnik = uczestnik;
        }
        
        [HttpPost("{idWydarzenie}",Name = "AddUczestnikToWydarzenie")]
        public IActionResult AddUczestnikToWydarzenie(int idWydarzenie)
        {
            string userId = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[3].Value;
            return Ok(_uczestnik.AddUczestnikToWydarzenie(idWydarzenie, userId));
        }

    }
}