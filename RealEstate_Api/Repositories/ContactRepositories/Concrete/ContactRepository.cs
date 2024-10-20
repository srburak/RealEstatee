using Dapper;
using RealEstate_Api.Dtos.ContactDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.ContactRepositories.Abstract;

namespace RealEstate_Api.Repositories.ContactRepositories.Concrete
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;

        public ContactRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultContactDto>> GetAllContact()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Last4ContactResultDto>> GetLast4Contact()
        {
            string query = "Select Top(4) * From Contact order by ContactID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4ContactResultDto>(query);
                return values.ToList();
            }
        }

        public async Task CreateContact(CreateContactDto createContactDto)
        {
            string query = "insert into Contact (Name,Subject,Email,Message,SendDate) " +
                           "values (@name,@subject,@email,@message,@sendDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", createContactDto.Name);
            parameters.Add("@subject", createContactDto.Subject);
            parameters.Add("@email", createContactDto.Email);
            parameters.Add("@message", createContactDto.Message);
            parameters.Add("@sendDate", createContactDto.SendDate);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<GetByIdContactDto> GetContact(int id)
        {
            throw new NotImplementedException();
        }
    }
}
