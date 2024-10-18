using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.BottomGridDtos;
using RealEstate_Api.Repositories.BottomGridRepository.Abstract;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }

        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDto createBottomGrid)
        {
            _bottomGridRepository.CreateBottomGrid(createBottomGrid);
            return Ok("Kategori başarılı bir şekilde eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDto updateBottomGrid)
        {
            _bottomGridRepository.UpdateBottomGrid(updateBottomGrid);
            return Ok("Kategori başarılı bir şekilde güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGrid(int id)
        {
            var value = await _bottomGridRepository.GetBottomGrid(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
            _bottomGridRepository.DeleteBottomGrid(id);
            return Ok("Kategori başarılı bir şekilde silindi");
        }
    }
}
