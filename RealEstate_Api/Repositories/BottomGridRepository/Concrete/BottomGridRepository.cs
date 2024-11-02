using Dapper;
using RealEstate_Api.Dtos.BottomGridDtos;
using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.BottomGridRepository.Abstract;

namespace RealEstate_Api.Repositories.BottomGridRepository.Concrete
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "SELECT * FROM BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public async Task CreateBottomGrid(CreateBottomGridDto bottomGridDto)
        {
            string query = "INSERT INTO BottomGrid (Icon,Title,Description) VALUES (@icon,@title,@description)";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", bottomGridDto.Icon);
            parameters.Add("@title", bottomGridDto.Title);
            parameters.Add("@description", bottomGridDto.Description);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteBottomGrid(int id)
        {
            string query = "DELETE FROM BottomGrid WHERE BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            string query =
                "UPDATE BottomGrid SET Icon=@icon,Title=@title,Description=@description WHERE BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", updateBottomGridDto.BottomGridID);
            parameters.Add("@icon", updateBottomGridDto.Icon);
            parameters.Add("@title", updateBottomGridDto.Title);
            parameters.Add("@description", updateBottomGridDto.Description);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetByIdBottomGridDto> GetBottomGrid(int id)
        {
            string query = "SELECT * FROM BottomGrid WHERE BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdBottomGridDto>(query, parameters);
                return values;
            }
        }
    }
}
