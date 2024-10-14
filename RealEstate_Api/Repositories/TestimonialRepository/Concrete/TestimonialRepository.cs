using Dapper;
using RealEstate_Api.Dtos.TestimonialDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.TestimonialRepository.Abstract;

namespace RealEstate_Api.Repositories.TestimonialRepository.Concrete
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "SELECT * FROM Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }

        public async void CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            string query = "INSERT INTO Testimonial (NameSurname,Title,Commnet,Status)" +
                           " VALUES (@nameSurname,@title,@commnet,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@nameSurname", createTestimonialDto.NameSurname);
            parameters.Add("@title", createTestimonialDto.Title);
            parameters.Add("@commnet", createTestimonialDto.Commnet);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteTestimonial(int id)
        {
            string query = "DELETE FROM Testimonial WHERE TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            string query =
                "UPDATE Testimonial SET NameSurname=@nameSurname,Title=@title,Commnet=@commnet,Status=@status" +
                " WHERE TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("testimonialID",updateTestimonialDto.TestimonialID);
            parameters.Add("@nameSurname", updateTestimonialDto.NameSurname);
            parameters.Add("@title", updateTestimonialDto.Title);
            parameters.Add("@commnet", updateTestimonialDto.Commnet);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetByIdTestimonialDto> GetTestimonial(int id)
        {
            string query = "SELECT * FROM Testimonial WHERE TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdTestimonialDto>(query, parameters);
                return values;

            }
        }
    }
}
