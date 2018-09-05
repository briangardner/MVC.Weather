using System;
using Newtonsoft.Json;

namespace MVC.Weather.Domain.DomainModel
{
    public class Forecast
    {
        [JsonProperty("operationalMode")]
        public string OperationalMode { get; set; }
        [JsonProperty("srsName")]
        public string SrsName { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("creationDateLocal")]
        public string CreationDateLocal { get; set; }
        [JsonProperty("productionCenter")]
        public string ProductionCenter { get; set; }
        [JsonProperty("credit")]
        public string Credit { get; set; }
        [JsonProperty("moreInformation")]
        public string MoreInformation { get; set; }
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("time")]
        public Time Time { get; set; }
        [JsonProperty("data")]
        public Data Data { get; set; }
        [JsonProperty("currentobservation")]
        public CurrentObservation CurrentObservation { get; set; }
    }
}
