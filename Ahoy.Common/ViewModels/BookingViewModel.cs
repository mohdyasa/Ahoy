using System;
using System.ComponentModel.DataAnnotations;

namespace Ahoy.Common.ViewModels
{
    public record BookingViewModel([property: Required] Guid HotelId, [property: Required] bool isPaid, [property: Required] decimal Price, [property: Required] DateTime checkIn, [property: Required] DateTime checkOut)
    {
    }
}
