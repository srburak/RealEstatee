using RealEstate_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Api.Repositories.PopularLocationRepository.Abstract
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        Task CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        Task DeletePopularLocation(int id);
        Task UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIdPopularLocationDto> GetByIdPopularLocation(int id);
    }
}
