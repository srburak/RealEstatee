using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.AppUserRepository.Abstract;
using RealEstate_Api.Repositories.AppUserRepository.Concrete;
using RealEstate_Api.Repositories.BottomGridRepository.Abstract;
using RealEstate_Api.Repositories.BottomGridRepository.Concrete;
using RealEstate_Api.Repositories.CategoryRepository.Abstract;
using RealEstate_Api.Repositories.CategoryRepository.Concrete;
using RealEstate_Api.Repositories.ContactRepositories.Abstract;
using RealEstate_Api.Repositories.ContactRepositories.Concrete;
using RealEstate_Api.Repositories.EmployeeRepositories.Abstract;
using RealEstate_Api.Repositories.EmployeeRepositories.Concrete;
using RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories.Abstract;
using RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories.Concrete;
using RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories.Abstract;
using RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories.Concrete;
using RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories.Abstract;
using RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories.Concrete;
using RealEstate_Api.Repositories.MessageRepositories.Abstract;
using RealEstate_Api.Repositories.MessageRepositories.Concrete;
using RealEstate_Api.Repositories.PopularLocationRepository.Abstract;
using RealEstate_Api.Repositories.PopularLocationRepository.Concrete;
using RealEstate_Api.Repositories.ProductImageRepositories.Abstract;
using RealEstate_Api.Repositories.ProductImageRepositories.Concrete;
using RealEstate_Api.Repositories.ProductRepository.Abstract;
using RealEstate_Api.Repositories.ProductRepository.Concrete;
using RealEstate_Api.Repositories.PropertyAmenityRepositories.Abstract;
using RealEstate_Api.Repositories.PropertyAmenityRepositories.Concrete;
using RealEstate_Api.Repositories.ServicesRepository.Abstract;
using RealEstate_Api.Repositories.ServicesRepository.Concrete;
using RealEstate_Api.Repositories.StatisticsRepository.Abstract;
using RealEstate_Api.Repositories.StatisticsRepository.Concrete;
using RealEstate_Api.Repositories.SubFeatureRepositories.Abstract;
using RealEstate_Api.Repositories.SubFeatureRepositories.Concrete;
using RealEstate_Api.Repositories.TestimonialRepository.Abstract;
using RealEstate_Api.Repositories.TestimonialRepository.Concrete;
using RealEstate_Api.Repositories.ToDoListRepositories.Abstract;
using RealEstate_Api.Repositories.ToDoListRepositories.Concrete;
using RealEstate_Api.Repositories.WhoWeAreRepository.Abstract;
using RealEstate_Api.Repositories.WhoWeAreRepository.Concrete;

namespace RealEstate_Api.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddTransient<Context>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServicesRepository, ServicesRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();
        }
    }
}
