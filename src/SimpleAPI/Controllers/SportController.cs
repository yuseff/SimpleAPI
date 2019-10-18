using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Domain.Models;
using SimpleAPI.Domain.Services;
using SimpleAPI.Extensions;
using SimpleAPI.Resources;

namespace SimpleAPI.Controllers
{
    [Route("/api/[controller]")]
    public class SportController : Controller
    {
        private readonly ISportService _sportService;

        private readonly IMapper _mapper;

        public SportController(ISportService service, IMapper mapper)
        {
            _sportService = service;
            _mapper = mapper;  
        }

        [HttpGet]
        public async Task<IEnumerable<SportResource>> GetAllAsync()
        {
            var sports = await _sportService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Sport>, IEnumerable<SportResource>>(sports);
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveSportResource resource)
        {
            if (!ModelState.IsValid)
		        return BadRequest(ModelState.GetErrorMessages());

            var sport = _mapper.Map<SaveSportResource, Sport>(resource);
            var result = await _sportService.SaveAsync(sport);

	        if (!result.Success)
		        return BadRequest(result.Message);

	        var sportResource = _mapper.Map<Sport, SportResource>(result.Sport);
	        return Ok(sportResource);
        }

        // PUT /api/sport/100
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveSportResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var sport = _mapper.Map<SaveSportResource, Sport>(resource);
            var result = await _sportService.UpdateAsync(id, sport);

            if (!result.Success)
                return BadRequest(result.Message);

            var sportResource = _mapper.Map<Sport, SportResource>(result.Sport);
            return Ok(sportResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _sportService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var resource = _mapper.Map<Sport, SportResource>(result.Sport);
            return Ok(resource);
        }
    }
}