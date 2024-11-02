using Dapper;
using RealEstate_Api.Dtos.SubFeatureDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.SubFeatureRepositories.Abstract;

namespace RealEstate_Api.Repositories.SubFeatureRepositories.Concrete
{
    public class SubFeatureRepository : ISubFeatureRepository
    {
        private readonly Context _context;
        public SubFeatureRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync()
        {
            string query = "Select * From SubFeature";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultSubFeatureDto>(query);
                return values.ToList();
            }
        }
    }
}
