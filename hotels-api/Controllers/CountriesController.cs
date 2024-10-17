using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using hotels_api.Data;
using hotels_api.Models.Country;
using AutoMapper;
using hotels_api.Contracts;
using Microsoft.AspNetCore.Authorization;
using hotels_api.Models.QueryParamters;
using Microsoft.AspNetCore.OData.Query;

namespace hotels_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICountriesRepository _repository;

        public CountriesController(IMapper mapper, ICountriesRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        // GET: api/Countries/?StartIndex=0&PageSize=15&PageNumber=1
        [HttpGet("GetAll")]
        public async Task<ActionResult<PageResult<GetCountryDto>>> GetPagedCountries([FromQuery] QueryParameters parameters)
        {
            return Ok(await _repository.GetAllAsync<GetCountryDto>(parameters));
        }

        // GET: api/Countries
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<GetCountryDto>>> GetCountries()
        {
            var countries = await _repository.GetAllAsync();
            var records = _mapper.Map<List<GetCountryDto>>(countries);

            return Ok(records);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryDto>> GetCountry(int id)
        {
            var country = await _repository.GetDetails(id);

            if (country == null)
            {
                return NotFound();
            }

            var record = _mapper.Map<CountryDto>(country);

            return record;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutCountry(int id, UpdateCountryDto updateCountry)
        {
            if (id != updateCountry.Id)
            {
                return BadRequest();
            }

            //_context.Entry(updateCountry).State = EntityState.Modified;

            var country = await _repository.GetAsync(id);

            if (country == null)
            {
                return NotFound();
            }

            _mapper.Map(updateCountry, country);

            try
            {
                await _repository.UpdateAsync(country);
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(CreateCountryDto createCountry)
        {
            var country = _mapper.Map<Country>(createCountry);

            await _repository.AddAsync(country);

            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            await _repository.DeleteAsync(id);

            return NoContent();
        }
    }
}
