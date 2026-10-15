using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class TemperatureControlSystemStatus
    {
        [JsonPropertyName("systemId")]
        public string SystemId
        {
            get;
            set;
        }
        [JsonPropertyName("zones")]
        public List<ZoneStatus> Zones
        {
            get;
            set;
        }
        [JsonPropertyName("activeFaults")]
        public List<string> ActiveFaults
        {
            get;
            set;
        }
        [JsonPropertyName("systemModeStatus")]
        public SystemModeStatus SystemModeStatus
        {
            get;
            set;
        }
        [JsonPropertyName("dhw")]
        public DHWStatus DomesticHotWater
        {
            get;
            set;
        }
    }
}