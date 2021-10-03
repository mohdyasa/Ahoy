using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Repository.Models
{
    public class HotelFacilities: BaseModel
    {
        public int Id { get; set; }
        public Guid HotelId { get; set; }
        public Guid FacilityId { get; set; }
    }
}
