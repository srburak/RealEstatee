using Dapper;
using RealEstate_Api.Dtos.PropertyAmentiyDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.PropertyAmenityRepositories.Abstract;

namespace RealEstate_Api.Repositories.PropertyAmenityRepositories.Concrete
{
    public class PropertyAmenityRepository : IPropertyAmenityRepository
    {
        private readonly Context _context;
        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id)
        {
            string query = "Select PropertyAmenityId,Title From PropertyAmenity Inner Join Amenities On Amenities.AmenityId=PropertyAmenity.AmenityId " +
                           "Where PropertyId=@propertyId And Status=1";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyAmenityByStatusTrueDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
