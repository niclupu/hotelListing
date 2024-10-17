using System;
using System.ComponentModel.DataAnnotations;

namespace hotels_api.Models.Hotel
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }
    }


    public class CreateHotelDto
    {
    }
}
