using Newtonsoft.Json;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class TemperatureControlSystemStatus
    {
        [JsonProperty("systemId")]
        public string SystemId
        {
            get;
            set;
        }
        [JsonProperty("zones")]
        public List<ZoneStatus> Zones
        {
            get;
            set;
        }
        [JsonProperty("activeFaults")]
        public List<string> ActiveFaults
        {
            get;
            set;
        }
        [JsonProperty("systemModeStatus")]
        public SystemModeStatus SystemModeStatus
        {
            get;
            set;
        }
        [JsonProperty("dhw")]
        public DHWStatus DomesticHotWater
        {
            get;
            set;
        }
    }
}