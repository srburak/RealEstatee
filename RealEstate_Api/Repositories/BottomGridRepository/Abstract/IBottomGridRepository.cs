using RealEstate_Api.Dtos.BottomGridDtos;
using RealEstate_Api.Dtos.CategoryDtos;

namespace RealEstate_Api.Repositories.BottomGridRepository.Abstract
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto bottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto bottomGridDto);
        Task<GetByIdBottomGridDto> GetBottomGrid(int id);
    }
}
