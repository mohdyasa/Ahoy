using System;

namespace Ahoy.Repository.Models
{
    public class Review: BaseModel
    {

            public Guid ID { get; set; }
            public Guid HotelId { get; set; }
            public string ReviewerName { get; set; }
            public string ReviewerEmail { get; set; }
            public string Description { get; set; }
            public int Rating { get; set; }
    }
}
