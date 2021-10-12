using Ethisys.NetCoreAPI.Controllers;
using Ethisys.NetCoreAPI.Models;
using Ethisys.NetCoreBusiness.Interfaces;
using Ethisys.NetCoreDomain.Dtos;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Ethisys.NetCoreAPI.Tests
{
    public class ApiTests
    {
        private readonly ProductsController _productsController;
        Mock<IEthisysBusiness> _ethisysBusiness;

        public ApiTests()
        {
            _ethisysBusiness = new Mock<IEthisysBusiness>();
            _productsController = new ProductsController(null, _ethisysBusiness.Object);
        }

        [Fact]
        public async Task GetProducts_AllOk_ReturnListOfProducts()
        {
            // Arrange
            _ethisysBusiness.Setup(x => x.GetProducts())
                .ReturnsAsync(new List<ProductDto> { new ProductDto { Manufacturer = new ManufacturerDto() } });

            // Act
            var result = await _productsController.GetProducts();

            // Assert
            Assert.IsAssignableFrom<IEnumerable<ProductModel>>(result);
            Assert.NotEmpty(result);
        }
    }
}
