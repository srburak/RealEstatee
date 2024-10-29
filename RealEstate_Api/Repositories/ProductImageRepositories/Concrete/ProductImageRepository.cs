using RealEstate_Api.Dtos.ProductImageDtos;
using RealEstate_Api.Repositories.ProductImageRepositories.Abstract;

namespace RealEstate_Api.Repositories.ProductImageRepositories.Concrete
{
    public class ProductImageRepository : IProductImageRepository
    {
        public async Task<GetProductImageByProductIdDto> GetProductImageByProductId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
