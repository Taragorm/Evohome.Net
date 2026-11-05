using Newtonsoft.Json;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class DHWStateCapabilities
    {
        [JsonProperty("allowedStates")]
        public List<string> AllowedStates
        {
            get;
            set;
        }
        [JsonProperty("allowedModes")]
        public List<string> AllowedModes
        {
            get;
            set;
        }
        [JsonProperty("maxDuration")]
        public string MaxDuration
        {
            get;
            set;
        }
        [JsonProperty("timingResolution")]
        public string TimingResolution
        {
            get;
            set;
        }
    }
}