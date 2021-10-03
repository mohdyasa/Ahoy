using Ahoy.Api.Facade;
using Ahoy.Common.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Ahoy.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelFacade service;
        private readonly ILogger<HotelController> logger;

        public HotelController(IHotelFacade service, ILogger<HotelController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        [HttpGet("hotelDetails")]
        public async Task<IActionResult> GetHotelDetails([FromQuery] string hotelId)
        {
            try
            {
                logger.LogInformation($"Started Processing request for HotelId : {hotelId} ");

                return Ok(await service.GetDetails(hotelId));
            }
            catch (Exception ex)
            {
                logger.LogError($"Error Processing Request for HotelId: {hotelId}", ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }
        [HttpGet("hotels")]
        public async Task<IActionResult> Hotels([FromQuery] SearchParams search)
        {
            try
            {
                return Ok(await service.GetHotels(search));
            }
            catch (Exception ex)
            {
                logger.LogError($"Error Processing Request for Search: {search.Name}", ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }

       
    }
}
