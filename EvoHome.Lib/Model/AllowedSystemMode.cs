using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class AllowedSystemMode
    {
        [JsonProperty("systemMode")]
        public string SystemMode
        {
            get;
            set;
        }

        [JsonProperty("canBePermanent")]
        public bool CanBePermanent
        {
            get;
            set;
        }

        [JsonProperty("canBeTemporary")]
        public bool CanBeTemporary
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
        [JsonProperty("timingMode")]
        public string TimingMode
        {
            get;
            set;
        }
    }
}