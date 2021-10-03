using Ahoy.Common.ViewModels;
using Ahoy.Services.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Services.Hotels
{
    public interface IHotelService
    {
        Task<HotelsViewModel> GetDetails(string hotelId);
        Task<IEnumerable<HotelListViewModel>> GetHotels(SearchParams searchParams);
        Task<IEnumerable<HotelListViewModel>> GetHotels();

    }
}
