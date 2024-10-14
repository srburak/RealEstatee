using RealEstate_Api.Dtos.TestimonialDtos;

namespace RealEstate_Api.Repositories.TestimonialRepository.Abstract
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        void CreateTestimonial(CreateTestimonialDto createTestimonialDto);
        void DeleteTestimonial(int id);
        void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto);
        Task<GetByIdTestimonialDto> GetTestimonial(int id);
    }
}
