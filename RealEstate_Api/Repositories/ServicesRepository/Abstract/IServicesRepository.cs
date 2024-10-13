using RealEstate_Api.Dtos.ServiceDtos;

namespace RealEstate_Api.Repositories.ServicesRepository.Abstract
{
    public interface IServicesRepository
    {
        Task<List<ResultServiceDto>> GetAllServicesAsync();
        void CreateService(CreateServiceDto createServiceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateServiceDto);
        Task<GetByIdServiceDto> GetService(int id);
    }
}
