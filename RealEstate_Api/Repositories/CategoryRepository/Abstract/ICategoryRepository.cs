using RealEstate_Api.Dtos.CategoryDtos;

namespace RealEstate_Api.Repositories.CategoryRepository.Abstract
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();
        Task CreateCategory(CreateCategoryDto category);
        Task DeleteCategory(int id);
        Task UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIdCategoryDto> GetCategory(int id);
    }
}
