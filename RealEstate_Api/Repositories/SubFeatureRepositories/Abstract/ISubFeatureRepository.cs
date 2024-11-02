using RealEstate_Api.Dtos.SubFeatureDtos;

namespace RealEstate_Api.Repositories.SubFeatureRepositories.Abstract
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();

    }
}
