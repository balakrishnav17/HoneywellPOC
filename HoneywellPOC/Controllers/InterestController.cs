using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneywellPOC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoneywellPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        public SimpleInterest Si { get; }
        public InterestController(SimpleInterest si)
        {
            Si = si;
        }

        [HttpPost("simpleInterest")]
        public IActionResult SimpleInterest(double amount, double year, double rate, int den = 100)
        {
            if (Double.IsNaN(rate))
                return BadRequest("Rate should not be empty");

            if (amount == 0 || year == 0 || rate == 0)
                return NoContent();
            var result = new ApiResponse
            {
                status = "success",
                result = Si.calculateInterest(amount, rate, year, den)
            };
            return Ok(result);
        }
    }
}
