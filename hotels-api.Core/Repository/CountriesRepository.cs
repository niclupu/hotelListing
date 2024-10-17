using System;
using AutoMapper;
using hotels_api.Contracts;
using hotels_api.Data;
using Microsoft.EntityFrameworkCore;

namespace hotels_api.Repository
{
	public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;

		public CountriesRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries
                .Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
