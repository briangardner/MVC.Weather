using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MVC.Weather.Domain.DomainModel
{
    public class Time
    {
        [JsonProperty("layoutKey")]
        public string LayoutKey { get; set; }
        [JsonProperty("startPeriodName")]
        public List<string> StartPeriodName { get; set; }
        [JsonProperty("startValidTime")]
        public List<DateTime> StartValidTime { get; set; }
        [JsonProperty("tempLabel")]
        public List<string> TempLabel { get; set; }
    }
}
