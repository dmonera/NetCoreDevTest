using Ethisys.NetCoreBusiness.Interfaces;
using Ethisys.NetCoreDomain.Dtos;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ethisys.NetCoreBusiness
{
    public class EthisysBusiness : IEthisysBusiness
    {
        private readonly ILogger<EthisysBusiness> _logger;
        private readonly IInventoryData _inventoryData;

        public EthisysBusiness(IInventoryData inventoryData, ILogger<EthisysBusiness> logger)
        {
            _logger= logger;
            _inventoryData=inventoryData;
        }

        /// <summary>
        /// Call to the external API and return the results as a List. 
        /// As there is no data transformation nor manipulation is a straigh forward to the caller interface/method
        /// </summary>
        /// <returns>Asynchronous task containing all the products</returns>
        public Task<IEnumerable<ProductDto>> GetProducts()
        {
            return _inventoryData.GetInventory();
        }
    }
}
