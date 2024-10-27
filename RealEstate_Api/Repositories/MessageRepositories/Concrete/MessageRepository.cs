using Dapper;
using RealEstate_Api.Dtos.MessageDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.MessageRepositories.Abstract;

namespace RealEstate_Api.Repositories.MessageRepositories.Concrete
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id)
        {
            string query = "Select Top(3) MessageId,Name,Subject,Detail,SendDate,IsRead,UserImageUrl " +
                           "From Message Inner Join AppUsers On Message.Sender=AppUsers.UserId" +
                           " Where Receiver=@receiverId Order By MessageId Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@receiverId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = 
                    await connection.QueryAsync<ResultInBoxMessageDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
