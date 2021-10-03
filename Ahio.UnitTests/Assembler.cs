using Ahoy.Common.ViewModels;
using System;

namespace Ahio.UnitTests
{
    public class Assembler
    {
        public static BookingViewModel bookingViewModel;
        public static void AssembleBookingData()
        {
            bookingViewModel = new BookingViewModel(Guid.NewGuid(), true, 8900, DateTime.Now, DateTime.Now.AddDays(8));
        }
    }
}
