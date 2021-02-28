using Calculate.API.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculate.API.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly IMediator mediator;

        public CalculatorController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        // GET: api/<CalculatorController>
        [HttpPost("totalcostdiscount")]
        public async Task<IActionResult> TotalCostDiscount(TotalCostDiscountCommand totalCostDiscountCommand)
        {
            var rs = await mediator.Send(totalCostDiscountCommand);
            return rs != null ? Ok(rs) : NotFound();
        }

    }
}
