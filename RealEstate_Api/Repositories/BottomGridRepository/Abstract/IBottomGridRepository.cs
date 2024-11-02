using RealEstate_Api.Dtos.BottomGridDtos;
using RealEstate_Api.Dtos.CategoryDtos;

namespace RealEstate_Api.Repositories.BottomGridRepository.Abstract
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        Task CreateBottomGrid(CreateBottomGridDto bottomGridDto);
        Task DeleteBottomGrid(int id);
        Task UpdateBottomGrid(UpdateBottomGridDto bottomGridDto);
        Task<GetByIdBottomGridDto> GetBottomGrid(int id);
    }
}
