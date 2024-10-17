using System;
using hotels_api.Data;
using hotels_api.Models.QueryParamters;

namespace hotels_api.Contracts
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T?> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<PageResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);

        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);

        Task<bool> Exists(int id);
    }
}
