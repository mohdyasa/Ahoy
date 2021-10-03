using Ahoy.Common.ViewModels;
using System.Threading.Tasks;

namespace Ahoy.Services.Strategy
{
    public interface ISearch
    {
        Task<HotelListViewModel> GetHotels(SearchParams searchParams);
    }
}
