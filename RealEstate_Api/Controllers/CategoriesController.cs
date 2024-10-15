using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Repositories.CategoryRepository.Abstract;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategoriesAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto category)
        {
            _categoryRepository.CreateCategory(category);
            return Ok("Kategori başarılı bir şekilde eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto categoryDto)
        {
            _categoryRepository.UpdateCategory(categoryDto);
            return Ok("Kategori başarılı bir şekilde güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _categoryRepository.GetCategory(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok("Kategori başarılı bir şekilde silindi");
        }
    }
}
