using Newtonsoft.Json;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class HeatSetpointCapabilities
    {
        [JsonProperty("maxHeatSetpoint")]
        public double MaxHeatSetpoint
        {
            get;
            set;
        }
        [JsonProperty("minHeatSetpoint")]
        public double MinHeatSetpoint
        {
            get;
            set;
        }
        [JsonProperty("valueResolution")]
        public double ValueResolution
        {
            get;
            set;
        }
        [JsonProperty("allowedSetpointModes")]
        public List<string> AllowedSetpointModes
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