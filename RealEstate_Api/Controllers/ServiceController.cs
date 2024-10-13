using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Dtos.ServiceDtos;
using RealEstate_Api.Repositories.ServicesRepository.Abstract;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServicesRepository _servicesRepository;

        public ServiceController(IServicesRepository servicesRepository)
        {
            _servicesRepository = servicesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _servicesRepository.GetAllServicesAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            _servicesRepository.CreateService(createServiceDto);
            return Ok("Servis başarılı bir şekilde eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            _servicesRepository.UpdateService(updateServiceDto);
            return Ok("Servis başarılı bir şekilde güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _servicesRepository.GetService(id);
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            _servicesRepository.DeleteService(id);
            return Ok("Servis başarılı bir şekilde silindi");
        }
    }
}
