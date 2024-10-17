using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.BottomGridRepository.Abstract;
using RealEstate_Api.Repositories.BottomGridRepository.Concrete;
using RealEstate_Api.Repositories.CategoryRepository.Abstract;
using RealEstate_Api.Repositories.CategoryRepository.Concrete;
using RealEstate_Api.Repositories.EmployeeRepositories.Abstract;
using RealEstate_Api.Repositories.EmployeeRepositories.Concrete;
using RealEstate_Api.Repositories.PopularLocationRepository.Abstract;
using RealEstate_Api.Repositories.PopularLocationRepository.Concrete;
using RealEstate_Api.Repositories.ProductRepository.Abstract;
using RealEstate_Api.Repositories.ProductRepository.Concrete;
using RealEstate_Api.Repositories.ServicesRepository.Abstract;
using RealEstate_Api.Repositories.ServicesRepository.Concrete;
using RealEstate_Api.Repositories.StatisticsRepository.Abstract;
using RealEstate_Api.Repositories.StatisticsRepository.Concrete;
using RealEstate_Api.Repositories.TestimonialRepository.Abstract;
using RealEstate_Api.Repositories.TestimonialRepository.Concrete;
using RealEstate_Api.Repositories.WhoWeAreRepository.Abstract;
using RealEstate_Api.Repositories.WhoWeAreRepository.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient();
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServicesRepository, ServicesRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
