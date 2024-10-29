using RealEstate_Api.Dtos.ProductImageDtos;

namespace RealEstate_Api.Repositories.ProductImageRepositories.Abstract
{
    public interface IProductImageRepository
    {
        Task<GetProductImageByProductIdDto> GetProductImageByProductId(int id);
    }
}
