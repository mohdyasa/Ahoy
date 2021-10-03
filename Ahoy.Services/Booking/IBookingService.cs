using Ahoy.Common.ViewModels;
using Ahoy.Services.BaseService;
using System.Threading.Tasks;

namespace Ahoy.Services.Booking
{
    public interface IBookingService: IBaseServiceParams
    {
        Task<bool> CreateBooking(BookingViewModel model);
    }
}
