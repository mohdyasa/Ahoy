using Ahoy.Common.ViewModels;
using Ahoy.Services.Booking;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Ahoy.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService service;
        private readonly ILogger<BookingsController> logger;
        public BookingsController(IBookingService service)
        {
            this.service = service;
        }
        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] BookingViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SetUpUserParams();
                    logger.LogInformation($"Started Processing for Request: { service.RequestId}");
                    var result = await service.CreateBooking(model);
                    return Created("~api/Bookings", model);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                logger.LogError($"Error Processing Request: {service.RequestId}", ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }

        private void SetUpUserParams()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            service.UserId = identity.FindFirst(ClaimTypes.NameIdentifier).Value;
            service.RequestId = Guid.NewGuid();
        }
    }
}
