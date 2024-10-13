using RealEstate_Api.Dtos.WhoWeAreDetailDtos;

namespace RealEstate_Api.Repositories.WhoWeAreRepository.Abstract
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
        void DeleteWhoWeAreDetail(int id);
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
    }
}
