using Ahoy.Common.ViewModels;
using Ahoy.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahoy.Services.Hotels
{
    public class HotelService : IHotelService
    {
        private readonly ILogger<HotelService> logger;
        private readonly ApplicationDbContext _context;
        public HotelService(ILogger<HotelService> logger, ApplicationDbContext context)
        {
            this.logger = logger;
            _context = context;
        }
        public async Task<HotelsViewModel> GetDetails(string hotelId)
        {
            var hotelDetails = await _context.Hotels.Where(x => x.ID.ToString() == hotelId).FirstOrDefaultAsync();
            if (hotelDetails == null)
                return null;

            var facilities = from hotelfacility in _context.HotelFacilities
                             join lookupFacilites in _context.Lookup_Facilities on hotelfacility.FacilityId equals lookupFacilites.ID
                             where hotelfacility.HotelId == hotelDetails.ID
                             select new FacilityViewModel(lookupFacilites.Name, lookupFacilites.Icon);

            var reviews = _context.Reviews.Where(x => x.HotelId == hotelDetails.ID).
                            Select(x => new ReviewViewModel(x.ReviewerName, x.Description, x.Rating)).ToList();
                           


            double? rating = reviews.Count == 0 ? null  :  reviews.Average(x => x.Rating);
            return new HotelsViewModel(hotelDetails.ID, hotelDetails.Name, rating, reviews, hotelDetails.Description, facilities.ToList(), hotelDetails.BasePrice);

        }

        public async Task<IEnumerable<HotelListViewModel>> GetHotels(SearchParams searchParams)
        {
            try
            {
                IQueryable<Hotel> query = _context.Hotels.Where(x =>
                             x.Name.IndexOf(searchParams.Name, 0, StringComparison.CurrentCultureIgnoreCase) != -1).AsQueryable();

                var result = await query.Select(x => new HotelListViewModel(x.Name, x.Location, x.Reviews.Count, x.BasePrice, x.ID)).ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public async Task<IEnumerable<HotelListViewModel>> GetHotels()
        {
            var hotelDetails = await _context.Hotels.Where(x => x.Available)
                .Include(x=> x.Reviews).Select(x=> new HotelListViewModel(x.Name, x.Location, x.Reviews.Count, x.BasePrice, x.ID)).ToListAsync();

            if (hotelDetails == null)
                return null;
            return hotelDetails;
        }
    }
}
