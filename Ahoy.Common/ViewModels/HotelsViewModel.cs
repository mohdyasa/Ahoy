using System;
using System.Collections.Generic;

namespace Ahoy.Common.ViewModels
{
    public record HotelsViewModel(Guid Id, string Name, double? Rating, List<ReviewViewModel> Reviews, string Description, List<FacilityViewModel> Facilities, decimal BasePrice)
    {

    }
    public record FacilityViewModel(string Icon, string Name)
    {
       
    }
    public record ReviewViewModel(string ReviewerName, string Description, int Rating)
    {

    }

}
