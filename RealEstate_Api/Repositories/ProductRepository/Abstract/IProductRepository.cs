using RealEstate_Api.Dtos.ProductDtos;

namespace RealEstate_Api.Repositories.ProductRepository.Abstract
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertsListByEmployeeAsyncByTrue(int id);
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertsListByEmployeeAsyncByFalse(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        void ProductDealOfTheDayStatusChangeToTrue(int id);
        void ProductDealOfTheDayStatusChangeToFalse(int id);
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();
        Task CreateProduct(CreateProductDto createProductDto);

    }
}
