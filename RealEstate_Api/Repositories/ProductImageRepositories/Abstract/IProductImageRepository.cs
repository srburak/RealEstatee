using RealEstate_Api.Dtos.ProductImageDtos;

namespace RealEstate_Api.Repositories.ProductImageRepositories.Abstract
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);
    }
}
