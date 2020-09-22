using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneywellPOC.Data;
using HoneywellPOC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoneywellPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        public Maths Maths { get; }
        public OperationsController(Maths maths)
        {
            Maths = maths;
        }



        [HttpPost("add")]
        public IActionResult Add(double a, double b)
        {
            if (a == 0 || b == 0)
                return NoContent();

            var result = new ApiResponse
            {
                status = "success",
                result = Maths.Add(a, b)
            };
            return Ok(result);
        }

        [HttpPost("substract")]
        public IActionResult Substract(double a, double b)
        {
            if (a == 0 || b == 0)
                return NoContent();

            var result = new ApiResponse
            {
                status = "success",
                result = Maths.Substract(a, b)
            };
            
            return Ok(result);
        }

        [HttpPost("multiply")]
        public IActionResult Multiply(double a, double b)
        {
            if (a == 0 || b == 0)
                return NoContent();

            var result = new ApiResponse
            {
                status = "success",
                result = Maths.Multiply(a, b)
            };
            return Ok(result);
        }

        [HttpPost("divide")]
        public IActionResult Divide(double a, int b)
        {
            if (a == 0)
                return NoContent();

            var result = new ApiResponse
            {
                status = "success",
                result = Maths.Divide(a, b)
            };
            return Ok(result);
        }
    }
}
