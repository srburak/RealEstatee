using RealEstate_Api.Dtos.ProductDetailDtos;
using RealEstate_Api.Dtos.ProductDtos;

namespace RealEstate_Api.Repositories.ProductRepository.Abstract
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertsListByEmployeeAsyncByTrue(int id);
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertsListByEmployeeAsyncByFalse(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        Task ProductDealOfTheDayStatusChangeToTrue(int id);
        Task ProductDealOfTheDayStatusChangeToFalse(int id);
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();
        Task<List<ResultLast3ProductWithCategoryDto>> GetLast3ProductAsync();
        Task CreateProduct(CreateProductDto createProductDto);
        Task<GetProductByProductIdDto> GetProductByProductId(int id);
        Task<GetProductDetailByIdDto> GetProductDetailByIdDto(int id);
        Task<List<ResultProductWithSearchListDto>> ResultProductWithSearchList(string searchKeyValue, int propertyCategoryId, string city);
        Task<List<ResultProductWithCategoryDto>> GetProductDealOfTheDayTrueWithCategoryAsync();

    }
}
