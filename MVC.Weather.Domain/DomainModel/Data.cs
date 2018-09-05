using System.Collections.Generic;
using Newtonsoft.Json;

namespace MVC.Weather.Domain.DomainModel
{
    public class Data
    {
        [JsonProperty("temperature")]
        public List<string> Temperature { get; set; }
        [JsonProperty("pop")]
        public List<string> PercentageOfPrecipitation { get; set; }
        [JsonProperty("weather")]
        public List<string> Weather { get; set; }
        [JsonProperty("iconLink")]
        public List<string> IconLink { get; set; }
        [JsonProperty("hazard")]
        public List<string> Hazard { get; set; }
        [JsonProperty("hazardUrl")]
        public List<string> HazardUrl { get; set; }
        [JsonProperty("text")]
        public List<string> Text { get; set; }
    }
}