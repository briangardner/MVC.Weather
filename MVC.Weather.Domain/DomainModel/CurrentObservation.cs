using Newtonsoft.Json;

namespace MVC.Weather.Domain.DomainModel
{
    public class CurrentObservation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("elev")]
        public string Elev { get; set; }
        [JsonProperty("latitude")]
        public string Latitude { get; set; }
        [JsonProperty("longitude")]
        public string Longitude { get; set; }
        [JsonProperty("Date")]
        public string Date { get; set; }
        [JsonProperty("Temp")]
        public string Temp { get; set; }
        [JsonProperty("Dewp")]
        public string Dewp { get; set; }
        [JsonProperty("Relh")]
        public string Relh { get; set; }
        [JsonProperty("Winds")]
        public string Winds { get; set; }
        [JsonProperty("Windd")]
        public string Windd { get; set; }
        [JsonProperty("Gust")]
        public string Gust { get; set; }
        [JsonProperty("Weather")]
        public string Weather { get; set; }
        [JsonProperty("Weatherimage")]
        public string Weatherimage { get; set; }
        [JsonProperty("Visibility")]
        public string Visibility { get; set; }
        [JsonProperty("Altimeter")]
        public string Altimeter { get; set; }
        [JsonProperty("SLP")]
        public string Slp { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("WindChill")]
        public string WindChill { get; set; }
    }
}
