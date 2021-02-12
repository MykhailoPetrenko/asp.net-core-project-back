using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Party.WebApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public abstract class BaseController : Controller
    {

    }
}
