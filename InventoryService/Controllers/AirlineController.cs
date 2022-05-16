using AirlinesService.Models;
using AirlinesService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlinesService.Controllers
{
    [Route("api/flight")]
    [ApiController]
    public class AirlineController : ControllerBase
    {
        IAirlineRegister _airlineRegister;
        public AirlineController(IAirlineRegister airlineRegister)
        {
            _airlineRegister = airlineRegister;
        }

        [HttpGet("findairlineinventory")]
        public IActionResult FindAirlineInventory()
        {
            try
            {
                return Ok(_airlineRegister.FindAllAirlineDetails());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("airline/register")]
        public IActionResult RegisterNewAirline(TblAirlineDetails airlineDetail)
        {
            if (airlineDetail != null)
            {
                // airlineDetail.Id = 0;
                _airlineRegister.RegisterAirline(airlineDetail);
                return Ok();
            }
            return BadRequest();
        }
    }
}
