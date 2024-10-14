using RealEstate_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Api.Repositories.PopularLocationRepository.Abstract
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIdPopularLocationDto> GetByIdPopularLocation(int id);
    }
}
