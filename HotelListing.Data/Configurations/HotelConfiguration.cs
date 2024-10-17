using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace hotels_api.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Adress = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Adress = "George Town",
                    CountryId = 3,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Delphin Imperial",
                    Adress = "Suites and co",
                    CountryId = 4,
                    Rating = 4.5
                }
            );
        }
    }
}

