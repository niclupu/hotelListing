using System;
using hotels_api.Models;
using hotels_api.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace hotels_api.Contracts
{
	public interface IAuthManager
    {
		Task<IEnumerable<IdentityError>> Register(ApiUsersDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
        Task<string> CreateRefreshToken();
    }
}

