using Ahoy.Services.Booking;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Ahoy.Repository.Models;
namespace Ahio.UnitTests
{
    public class BookingTests
    {
        [Fact]
        public async void CreateBookings()
        {
            Assembler.AssembleBookingData();
            var bookingService = new BookingService(CreateLogger<BookingService>(), CreateDBContext());
            //var result = await bookingService.CreateBooking(Assembler.bookingViewModel);
        }
        private ILogger<T> CreateLogger<T>()
        {
            var mock = new Mock<ILogger<T>>();
            return mock.Object;
        }
        private ApplicationDbContext CreateDBContext()
        {
            var mock = new Mock<ApplicationDbContext>();
            return mock.Object;
        }
    }
}
