using System;

namespace Ahoy.Common.ViewModels
{
    public record HotelListViewModel(string Name, string Location, long rating, decimal BasePrice, Guid HotelID)
    {
    }
}
