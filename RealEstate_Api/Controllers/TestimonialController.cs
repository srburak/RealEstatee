using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Dtos.TestimonialDtos;
using RealEstate_Api.Repositories.TestimonialRepository.Abstract;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var values = await _testimonialRepository.GetAllTestimonialAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialRepository.CreateTestimonial(createTestimonialDto);
            return Ok("Kategori başarılı bir şekilde eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialRepository.UpdateTestimonial(updateTestimonialDto);
            return Ok("Kategori başarılı bir şekilde güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await _testimonialRepository.GetTestimonial(id);
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            _testimonialRepository.DeleteTestimonial(id);
            return Ok("Kategori başarılı bir şekilde silindi");
        }
    }
}
