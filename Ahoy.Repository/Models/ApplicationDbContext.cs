using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Repository.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Lookup_Facility> Lookup_Facilities { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<HotelFacilities> HotelFacilities { get; set; }

    }
}
