using Ahoy.Common.ViewModels;
using Ahoy.Services.Hotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahoy.Api.Facade
{
    public class HotelFacade : IHotelFacade
    {
        private readonly IHotelService service;

        public HotelFacade(IHotelService service)
        {
            this.service = service;
        }

        public async Task<HotelsViewModel> GetDetails(string hotelId)
        {
            return await service.GetDetails(hotelId);
        }

        public async Task<IEnumerable<HotelListViewModel>> GetHotels(SearchParams? searchParams = null)
        {
            if (searchParams == null)
                return await service.GetHotels(searchParams);

            return await service.GetHotels();
           
        }
    }
}
