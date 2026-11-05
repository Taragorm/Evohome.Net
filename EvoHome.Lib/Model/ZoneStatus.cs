using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Evohome.Lib
{
    public class ZoneStatus
    {
        [JsonProperty("zoneId")]
        public string ZoneId
        {
            get;
            set;
        }
        [JsonProperty("temperatureStatus")]
        public TemperatureStatus TemperatureStatus
        {
            get;
            set;
        }

        [JsonProperty("activeFaults")]
        public List<ActiveFault> ActiveFaults
        {
            get;
            set;
        }

        [JsonProperty("heatSetpointStatus")]
        public HeatSetpointStatus HeatSetpointStatus
        {
            get;
            set;
        } 

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }
}