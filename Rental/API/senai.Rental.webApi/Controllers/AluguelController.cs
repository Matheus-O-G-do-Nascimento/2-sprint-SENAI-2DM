using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rental.Domains;
using Rental.Interfaces;
using Rental.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class AluguelController : ControllerBase
    {
    }
}
