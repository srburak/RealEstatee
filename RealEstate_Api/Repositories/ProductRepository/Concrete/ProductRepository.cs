using Dapper;
using RealEstate_Api.Dtos.EmployeeDtos;
using RealEstate_Api.Dtos.ProductDetailDtos;
using RealEstate_Api.Dtos.ProductDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.ProductRepository.Abstract;

namespace RealEstate_Api.Repositories.ProductRepository.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }


        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "SELECT * FROM Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertsListByEmployeeAsyncByTrue(int id)
        {
            string query = "SELECT ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address,DealOfTheDay " +
                           "FROM Product inner join Category on" +
                           " Product.ProductCategory = Category.CategoryID where EmployeeID=@employeeID and ProductStatus=1";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await
                    connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query,parameters);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertsListByEmployeeAsyncByFalse(int id)
        {
            string query = "SELECT ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address,DealOfTheDay " +
                           "FROM Product inner join Category on" +
                           " Product.ProductCategory = Category.CategoryID where EmployeeID=@employeeID and ProductStatus=0";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await
                    connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "SELECT ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address,DealOfTheDay " +
                           "FROM Product inner join Category on Product.ProductCategory = Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await 
                    connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set DealOfTheDay=1 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set DealOfTheDay=0 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync()
        {
            string query = "SELECT TOP(5) ProductID,Title,Price,City,District,ProductCategory," +
                           "CategoryName,AdvertisementDate FROM Product Inner Join Category " +
                           "On Product.ProductCategory=Category.CategoryID " +
                           "Where Type='Kiralık' Order By ProductID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            string query = "insert into Product (Title,Price,City,District,CoverImage,Address,Description," +
                           "Type,DealOfTheDay,AdvertisementDate,ProductStatus,ProductCategory,EmployeeID) values " +
                           "(@Title,@Price,@City,@District,@CoverImage,@Address,@Description,@Type,@DealOfTheDay,@AdvertisementDate,@ProductStatus,@ProductCategory," +
                           "@EmployeeID)";
            var parameters = new DynamicParameters();
            parameters.Add("@Title", createProductDto.Title);
            parameters.Add("@Price", createProductDto.Price);
            parameters.Add("@City", createProductDto.City);
            parameters.Add("@District", createProductDto.District);
            parameters.Add("@CoverImage", createProductDto.CoverImage);
            parameters.Add("@Address", createProductDto.Address);
            parameters.Add("@Description", createProductDto.Description);
            parameters.Add("@Type", createProductDto.Type);
            parameters.Add("@DealOfTheDay", createProductDto.DealOfTheDay);
            parameters.Add("@AdvertisementDate", createProductDto.AdvertisementDate);
            parameters.Add("@ProductStatus", createProductDto.ProductStatus);
            parameters.Add("@ProductCategory", createProductDto.ProductCategory);
            parameters.Add("@EmployeeID", createProductDto.EmployeeID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetProductByProductIdDto> GetProductByProductId(int id)
        {
            string query =
                "SELECT ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address,DealOfTheDay,AdvertisementDate,Description " +
                "FROM Product inner join Category on Product.ProductCategory = Category.CategoryID where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductByProductIdDto>(query, parameters);
                return values.FirstOrDefault();
            }
        }

        public async Task<GetProductDetailByIdDto> GetProductDetailByIdDto(int id)
        {
            string query =
                "SELECT * From ProductDetails Where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductDetailByIdDto>(query, parameters);
                return values.FirstOrDefault();
            }
        }
    }
}
