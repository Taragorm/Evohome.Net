using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class ScheduleCapabilities
    {
        [JsonPropertyName("maxSwitchpointsPerDay")]
        public int MaxSwitchpointsPerDay
        {
            get;
            set;
        }

        [JsonPropertyName("minSwitchpointsPerDay")]
        public int MinSwitchpointsPerDay
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
        [JsonPropertyName("setpointValueResolution")]
        public double SetpointValueResolution
        {
            get;
            set;
        }
    }
}