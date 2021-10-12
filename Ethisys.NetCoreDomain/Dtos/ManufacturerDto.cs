using Newtonsoft.Json;

namespace Ethisys.NetCoreDomain.Dtos
{
    public class ManufacturerDto
    {
        [JsonProperty("name")]
        public string ManufacturerName {  get; set; }

        [JsonProperty("homePage")]
        public string ManufacturerUrl {  get; set; }

        [JsonProperty("phone")]
        public string ManufacturerPhone {  get; set; }
    }
}
