using System;
using System.Collections.Generic;

namespace Ahoy.Repository.Models
{
    public class Hotel: BaseModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public decimal ActualPrice { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public virtual List<Lookup_Facility> Facilities { get; set; }
        public virtual List<HotelImages> HotelImages { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public string Location { get; set; }

    }
}
