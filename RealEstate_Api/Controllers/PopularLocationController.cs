using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Dtos.PopularLocationDtos;
using RealEstate_Api.Repositories.PopularLocationRepository.Abstract;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            _popularLocationRepository.CreatePopularLocation(createPopularLocationDto);
            return Ok("Lokasyon başarılı bir şekilde eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            _popularLocationRepository.UpdatePopularLocation(updatePopularLocationDto);
            return Ok("Lokasyon başarılı bir şekilde güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocation(int id)
        {
            var value = await _popularLocationRepository.GetByIdPopularLocation(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            _popularLocationRepository.DeletePopularLocation(id);
            return Ok("Lokasyon başarılı bir şekilde silindi");
        }
    }
}
