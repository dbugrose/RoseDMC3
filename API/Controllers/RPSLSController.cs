using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RPSLSController : ControllerBase
    {
        private readonly RPSLSServices _rpslsServices;

        public RPSLSController(RPSLSServices rpslsServices)
        {
            _rpslsServices = rpslsServices;
        }

            [HttpPost("TypeRockPaperScissorsLizardOrSpock/{userinput}")]
        public string Rpsls(string userinput)
        {
            return _rpslsServices.RandomChoice(userinput);
        }
    }
}