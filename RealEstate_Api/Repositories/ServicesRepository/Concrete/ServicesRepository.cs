using Dapper;
using RealEstate_Api.Dtos.ServiceDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.ServicesRepository.Abstract;

namespace RealEstate_Api.Repositories.ServicesRepository.Concrete
{
    public class ServicesRepository : IServicesRepository
    {

        private readonly Context _context;

        public ServicesRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultServiceDto>> GetAllServicesAsync()
        {
            string query = "SELECT * FROM Services";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task CreateService(CreateServiceDto createServiceDto)
        {
            string query = "INSERT INTO Services (ServiceName,ServiceStatus) VALUES (@serviceName,@serviceStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", createServiceDto.ServiceName);
            parameters.Add("@serviceStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteService(int id)
        {
            string query = "DELETE FROM Services WHERE ServiceID=@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task UpdateService(UpdateServiceDto updateServiceDto)
        {
            string query =
                "UPDATE Services SET ServiceName=@serviceName,ServiceStatus=@serviceStatus WHERE ServiceID=@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", updateServiceDto.ServiceName);
            parameters.Add("@serviceStatus", updateServiceDto.ServiceStatus);
            parameters.Add("@serviceID", updateServiceDto.ServiceID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetByIdServiceDto> GetService(int id)
        {
            string query = "SELECT * FROM Services WHERE ServiceID=@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdServiceDto>(query, parameters);
                return values;

            }
        }
    }
}
