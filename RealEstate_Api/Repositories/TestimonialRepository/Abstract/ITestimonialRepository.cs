using RealEstate_Api.Dtos.TestimonialDtos;

namespace RealEstate_Api.Repositories.TestimonialRepository.Abstract
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        Task CreateTestimonial(CreateTestimonialDto createTestimonialDto);
        Task DeleteTestimonial(int id);
        Task UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto);
        Task<GetByIdTestimonialDto> GetTestimonial(int id);
    }
}
