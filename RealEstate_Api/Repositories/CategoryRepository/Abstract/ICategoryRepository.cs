using RealEstate_Api.Dtos.CategoryDtos;

namespace RealEstate_Api.Repositories.CategoryRepository.Abstract
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();
        void CreateCategory(CreateCategoryDto category);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIdCategoryDto> GetCategory(int id);
    }
}
