using System.ComponentModel.DataAnnotations;
namespace hotels_api.Models.Country
{
	public class CreateCountryDto: BaseCountryDTO
    {
    }

    public class UpdateCountryDto : BaseCountryDTO
    {
        public int Id { get; set; }
    }
}
