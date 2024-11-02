using RealEstate_Api.Dtos.ServiceDtos;

namespace RealEstate_Api.Repositories.ServicesRepository.Abstract
{
    public interface IServicesRepository
    {
        Task<List<ResultServiceDto>> GetAllServicesAsync();
        Task CreateService(CreateServiceDto createServiceDto);
        Task DeleteService(int id);
        Task UpdateService(UpdateServiceDto updateServiceDto);
        Task<GetByIdServiceDto> GetService(int id);
    }
}
