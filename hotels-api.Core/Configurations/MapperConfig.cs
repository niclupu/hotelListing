using AutoMapper;
using hotels_api.Data;
using hotels_api.Models;
using hotels_api.Models.Country;
using hotels_api.Models.Hotel;

namespace hotels_api.Configurations
{
	public class MapperConfig: Profile
	{
		public MapperConfig()
		{
			CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
            CreateMap<ApiUser, ApiUsersDto>().ReverseMap();
        }
    }
}
