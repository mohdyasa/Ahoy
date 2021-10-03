using Ahoy.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahoy.Api.Facade
{
    public interface IHotelFacade
    {
        Task<IEnumerable<HotelListViewModel>> GetHotels(SearchParams searchParams);
        Task<HotelsViewModel> GetDetails(string hotelId);


    }
}
