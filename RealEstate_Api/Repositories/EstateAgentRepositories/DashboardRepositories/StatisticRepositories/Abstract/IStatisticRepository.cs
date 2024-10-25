namespace RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories.Abstract
{
    public interface IStatisticRepository
    {
        int ProductCountByEmployeeId(int id);
        int ProductCountByStatusTrue(int id);
        int ProductCountByStatusFalse(int id);
        int AllProductCount();
    }
}
