using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class DHWStatus
    {
        [JsonPropertyName("dhwId")]
        public string DhwId
        {
            get;
            set;
        }
        [JsonPropertyName("temperatureStatus")]
        public TemperatureStatus Temperature
        {
            get;
            set;
        }
        [JsonPropertyName("stateStatus")]
        public StateStatus State
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
    }
}