using RealEstate_Api.Dtos.ContactDtos;

namespace RealEstate_Api.Repositories.ContactRepositories.Abstract
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContact();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        Task CreateContact(CreateContactDto createContactDto);
        Task DeleteContact(int id);
        Task<GetByIdContactDto> GetContact(int id);
    }
}
