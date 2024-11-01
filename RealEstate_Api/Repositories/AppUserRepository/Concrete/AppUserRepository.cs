using Dapper;
using RealEstate_Api.Dtos.AppUserDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.AppUserRepository.Abstract;


namespace RealEstate_Api.Repositories.AppUserRepository.Concrete
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly Context _context;

        public AppUserRepository(Context context)
        {
            _context = context;
        }

        public async Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id)
        {
            string query = "Select * From AppUsers Where UserId=@UserId";
            var parameters = new DynamicParameters();
            parameters.Add("@UserId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductIdDto>(query, parameters);
                return values;
            }
        }
    }
}
