using System;
using System.ComponentModel.DataAnnotations;

namespace hotels_api.Models.Hotel
{
    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }

        public double? Rating { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}
