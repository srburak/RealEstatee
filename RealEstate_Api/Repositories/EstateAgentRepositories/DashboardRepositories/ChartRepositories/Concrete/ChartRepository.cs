﻿using Dapper;
using RealEstate_Api.Dtos.ChartDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories.Abstract;

namespace RealEstate_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories.Concrete
{
    public class ChartRepository : IChartRepository
    {
        private readonly Context _context;
        public ChartRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultChartDto>> Get5CityForChart()
        {
            string query = "Select top(5) City,Count(*) as 'CityCount' From Product Group By City order By CityCount Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultChartDto>(query);
                return values.ToList();
            }
        }
    }
}
