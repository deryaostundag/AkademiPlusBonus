using AkademiPlusBonus.BusinessLayer.Abstract;
using AkademiPlusBonus.DtoLayer.ProductDto;
using AkademiPlusBonus.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusBonus.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);
            return Ok();
        }
        [HttpPost("ProductAddWithDto")]
        public IActionResult ProductAddWithDto(CreateProductDto createProductDto)
        {
            Product product = new Product()
            {
                ProductName= createProductDto.ProductName,
                ProductPrice= createProductDto.ProductPrice,
                CategoryID= createProductDto.CategoryID,
                ProductStock= createProductDto.ProductStock,
            };
            _productService.TInsert(product);
            return Ok();

        }
    }
}
