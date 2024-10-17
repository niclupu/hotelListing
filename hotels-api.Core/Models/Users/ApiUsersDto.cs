using System.ComponentModel.DataAnnotations;
using hotels_api.Models.Users;

namespace hotels_api.Models
{
	public class ApiUsersDto : LoginDto
    {
		[Required]
		public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
	}
}
