using Dapper;
using RealEstate_Api.Dtos.ProductImageDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.ProductImageRepositories.Abstract;

namespace RealEstate_Api.Repositories.ProductImageRepositories.Concrete
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly Context _context;
        public ProductImageRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id)
        {
            string query = "Select * From ProductImage Where ProductID=@ProductID";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = 
                    await connection.QueryAsync<GetProductImageByProductIdDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
