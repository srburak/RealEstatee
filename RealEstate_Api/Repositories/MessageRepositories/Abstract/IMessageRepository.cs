using RealEstate_Api.Dtos.MessageDtos;

namespace RealEstate_Api.Repositories.MessageRepositories.Abstract
{
    public interface IMessageRepository
    {
        Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id);
    }
}
