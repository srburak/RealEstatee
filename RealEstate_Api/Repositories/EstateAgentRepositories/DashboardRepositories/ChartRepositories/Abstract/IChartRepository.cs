using RealEstate_Api.Dtos.ChartDtos;

namespace RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories.Abstract
{
    public interface IChartRepository
    {
        Task<List<ResultChartDto>> Get5CityForChart();
    }
}
