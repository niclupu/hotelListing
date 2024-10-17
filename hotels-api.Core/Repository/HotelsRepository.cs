using System;
using AutoMapper;
using hotels_api.Contracts;
using hotels_api.Data;

namespace hotels_api.Repository
{
	public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
		public HotelsRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
		{

		}
	}
}

