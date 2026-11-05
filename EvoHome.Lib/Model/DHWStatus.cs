using Newtonsoft.Json;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class DHWStatus
    {
        [JsonProperty("dhwId")]
        public string DhwId
        {
            get;
            set;
        }
        [JsonProperty("temperatureStatus")]
        public TemperatureStatus Temperature
        {
            get;
            set;
        }
        [JsonProperty("stateStatus")]
        public StateStatus State
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
    }
}