using System.ComponentModel.DataAnnotations;
using hotels_api.Models.Hotel;

namespace hotels_api.Models.Country
{
	public class GetCountryDto: BaseCountryDTO
    {
        public int Id { get; set; }
    }

    public class CountryDto: BaseCountryDTO
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
