using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class DHWStateCapabilities
    {
        [JsonPropertyName("allowedStates")]
        public List<string> AllowedStates
        {
            get;
            set;
        }
        [JsonPropertyName("allowedModes")]
        public List<string> AllowedModes
        {
            get;
            set;
        }
        [JsonPropertyName("maxDuration")]
        public string MaxDuration
        {
            get;
            set;
        }
        [JsonPropertyName("timingResolution")]
        public string TimingResolution
        {
            get;
            set;
        }
    }
}