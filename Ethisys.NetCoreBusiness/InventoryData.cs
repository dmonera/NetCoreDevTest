using Ethisys.NetCoreBusiness.Interfaces;
using Ethisys.NetCoreDomain.Dtos;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ethisys.NetCoreBusiness
{
    public class InventoryData : IInventoryData
    {
        private readonly HttpClient _client;
        private readonly ILogger _logger;

        public InventoryData(HttpClient client, ILogger<InventoryData> logger)
        {
            _client = client;
            _logger = logger;
        }

        /// <summary>
        /// Call to the the external 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ProductDto>> GetInventory()
        {
            HttpResponseMessage responseMessage = await _client.GetAsync(_client.BaseAddress);
            string response = await responseMessage.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(response);
        }
    }
}