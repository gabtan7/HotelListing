using HotelListing.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext (DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());

            //builder.Entity<Country>().HasData(
            //    new Country { CountryId = 1, Name = "Jamaica", ShortName = "JM" },
            //    new Country { CountryId = 2, Name = "Bahamas", ShortName = "BS" },
            //    new Country { CountryId = 3, Name = "Cayman Island", ShortName = "CI" }
            //    );

            //builder.Entity<Hotel>().HasData(
            //    new Hotel { HotelId = 1, Name = "Resort 1", Address = "Address 1", CountryId = 1, Rating = 1.1 },
            //    new Hotel { HotelId = 2, Name = "Resort 2", Address = "Address 2", CountryId = 2, Rating = 2.5 },
            //    new Hotel { HotelId = 3, Name = "Resort 3", Address = "Address 3", CountryId = 3, Rating = 3.4 }
            //    );
        }
    }
}
