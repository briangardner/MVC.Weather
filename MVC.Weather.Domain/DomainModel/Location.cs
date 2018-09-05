using Newtonsoft.Json;

namespace MVC.Weather.Domain.DomainModel
{

    public class Location
    {
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("latitude")]
        public string Latitude { get; set; }
        [JsonProperty("longitude")]
        public string Longitude { get; set; }
        [JsonProperty("elevation")]
        public string Elevation { get; set; }
        [JsonProperty("wfo")]
        public string Wfo { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("areaDescription")]
        public string AreaDescription { get; set; }
        [JsonProperty("radar")]
        public string Radar { get; set; }
        [JsonProperty("zone")]
        public string Zone { get; set; }
        [JsonProperty("county")]
        public string County { get; set; }
        [JsonProperty("firezone")]
        public string FireZone { get; set; }
        [JsonProperty("metar")]
        public string Metar { get; set; }
    }
}
