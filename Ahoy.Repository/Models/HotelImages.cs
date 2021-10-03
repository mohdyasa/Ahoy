using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Repository.Models
{
    public class HotelImages:  BaseModel
    {
        public Guid ID { get; set; }
        public string ImageUrl { get; set; }
        public Guid HotelId { get; set; }

    }
}
