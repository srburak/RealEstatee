using Dapper;
using RealEstate_Api.Dtos.ProductDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories.Abstract;

namespace RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories.Concrete
{
    public class Last5ProductsRepository : ILast5ProductsRepository
    {
        private readonly Context _context;
        public Last5ProductsRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id)
        {
            string query = "Select Top(5) ProductID,Title,Price,City,District,ProductCategory,CategoryName,AdvertisementDate From Product Inner Join Category On Product.ProductCategory=Category.CategoryID Where EmployeeId=@employeeId Order By ProductID Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
