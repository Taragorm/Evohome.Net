using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class HeatSetpointCapabilities
    {
        [JsonPropertyName("maxHeatSetpoint")]
        public double MaxHeatSetpoint
        {
            get;
            set;
        }
        [JsonPropertyName("minHeatSetpoint")]
        public double MinHeatSetpoint
        {
            get;
            set;
        }
        [JsonPropertyName("valueResolution")]
        public double ValueResolution
        {
            get;
            set;
        }
        [JsonPropertyName("allowedSetpointModes")]
        public List<string> AllowedSetpointModes
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