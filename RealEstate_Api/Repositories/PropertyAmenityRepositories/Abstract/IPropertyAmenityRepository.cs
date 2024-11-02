using RealEstate_Api.Dtos.PropertyAmentiyDtos;

namespace RealEstate_Api.Repositories.PropertyAmenityRepositories.Abstract
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id);

    }
}
