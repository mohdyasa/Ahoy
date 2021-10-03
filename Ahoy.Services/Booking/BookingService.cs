using Ahoy.Common.ViewModels;
using Ahoy.Repository.Models;
using Ahoy.Services.BaseService;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Ahoy.Services.Booking
{
    public class BookingService : BaseServiceParams, IBookingService
    {
        private readonly ILogger<BookingService> logger;
        private readonly ApplicationDbContext _context;
        public BookingService(ILogger<BookingService> logger, ApplicationDbContext context)
        {
            this.logger = logger;
            _context = context;
        }
        public async Task<bool> CreateBooking(BookingViewModel model)
        {
            try
            {
                Bookings bookings = new Bookings
                {
                    CheckIn = model.checkIn,
                    CheckOut = model.checkOut,
                    //CreatedBy = User
                    CreatedOn = System.DateTime.Now,
                    HotelID = model.HotelId,
                    Paid = model.isPaid,
                    TotalFee = model.Price,
                    CreatedBy = UserId
                };

                _context.Bookings.Add(bookings);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
