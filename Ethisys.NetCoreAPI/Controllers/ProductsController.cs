using Ethisys.NetCoreAPI.Models;
using Ethisys.NetCoreBusiness.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ethisys.NetCoreAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IEthisysBusiness _ethisysBusiness;

        public ProductsController(ILogger<ProductsController> logger, IEthisysBusiness ethisysBusiness)
        {
            _logger = logger;
            _ethisysBusiness = ethisysBusiness;
        }

        /// <summary>
        /// Call and get all the products without any filter
        /// </summary>
        /// <returns>Asynchronous task containing all the products with it´s manufacturers</returns>
        [HttpGet]
        [Route("getall")]
        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            try
            {
                // You can use AutoMapper or something similar but I prefer to do it myself and be sure about what´s going on.
                return (await _ethisysBusiness.GetProducts().ConfigureAwait(false))
                    .Select(x => new ProductModel
                    {
                        DateAvailable = x.DateAvailable,
                        Id = x.Id,
                        ProductName = x.ProductName,
                        Manufacturer = new ManufacturerModel
                        {
                            ManufacturerName = x.Manufacturer.ManufacturerName,
                            ManufacturerPhone = x.Manufacturer.ManufacturerPhone,
                            ManufacturerUrl = x.Manufacturer.ManufacturerUrl
                        }
                    });
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR fetching products - Message: {ex.Message}, Trace: {ex.StackTrace}, Inner Exception: {ex.InnerException} ");
                throw;
            }
        }
    }
}