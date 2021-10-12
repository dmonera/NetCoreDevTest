using Newtonsoft.Json;
using System;

namespace Ethisys.NetCoreDomain.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string ProductName { get; set; }

        [JsonProperty("releaseDate")]
        public DateTime DateAvailable { get; set; }

        public ManufacturerDto Manufacturer { get; set; }
    }
}
