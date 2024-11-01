using RealEstate_Api.Dtos.AppUserDtos;

namespace RealEstate_Api.Repositories.AppUserRepository.Abstract
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id);
    }
}
