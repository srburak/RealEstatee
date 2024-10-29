using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.ProductRepository.Abstract;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {

        private readonly IProductRepository _productRepository;

        public ProductDetailsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        [HttpGet("GetProductDetailByIdDto")]
        public async Task<IActionResult> GetProductDetailByIdDto(int id)
        {
            var values = await _productRepository.GetProductDetailByIdDto(id);
            return Ok(values);
        }
    }
}
