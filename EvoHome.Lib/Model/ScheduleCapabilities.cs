using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class ScheduleCapabilities
    {
        [JsonProperty("maxSwitchpointsPerDay")]
        public int MaxSwitchpointsPerDay
        {
            get;
            set;
        }

        [JsonProperty("minSwitchpointsPerDay")]
        public int MinSwitchpointsPerDay
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
        [JsonProperty("setpointValueResolution")]
        public double SetpointValueResolution
        {
            get;
            set;
        }
    }
}