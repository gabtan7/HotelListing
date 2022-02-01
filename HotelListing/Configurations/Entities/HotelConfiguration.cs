using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel { HotelId = 1, Name = "Resort 1", Address = "Address 1", CountryId = 1, Rating = 1.1 },
                new Hotel { HotelId = 2, Name = "Resort 2", Address = "Address 2", CountryId = 2, Rating = 2.5 },
                new Hotel { HotelId = 3, Name = "Resort 3", Address = "Address 3", CountryId = 3, Rating = 3.4 }
                );
        }
    }
}
