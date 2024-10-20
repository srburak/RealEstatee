using Dapper;
using RealEstate_Api.Dtos.ToDoListDots;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.ToDoListRepositories.Abstract;

namespace RealEstate_Api.Repositories.ToDoListRepositories.Concrete
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly Context _context;

        public ToDoListRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultToDoListDto>> GetAllToDoList()
        {
            string query = "Select * From ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDto>(query);
                return values.ToList();
            }
        }

        public async Task CreateToDoList(CreateToDoListDto ToDoListDto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateToDoList(UpdateToDoListDto ToDoListDto)
        {
            throw new NotImplementedException();
        }

        public async Task<GetByIDToDoListDto> GetToDoList(int id)
        {
            throw new NotImplementedException();
        }
    }
}
