using Ahoy.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Services.Strategy
{
    public class SearchHotelClient
    {
        private readonly ISearch search;

        public SearchHotelClient(ISearch search)
        {
            this.search = search;
        }
        //public IEnumerable<HotelListViewModel> GetHotels()
        //{
        //    return search.GetHotels()
        //}
    }
}
