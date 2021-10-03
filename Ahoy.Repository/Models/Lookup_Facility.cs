using System;

namespace Ahoy.Repository.Models
{
    public class Lookup_Facility: BaseModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}