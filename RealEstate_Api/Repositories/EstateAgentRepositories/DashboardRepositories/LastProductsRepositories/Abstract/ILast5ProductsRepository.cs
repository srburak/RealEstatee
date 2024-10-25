using RealEstate_Api.Dtos.ProductDtos;

namespace RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories.Abstract
{
    public interface ILast5ProductsRepository
    {
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id);

    }
}
