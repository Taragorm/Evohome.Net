using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class AllowedSystemMode
    {
        [JsonPropertyName("systemMode")]
        public string SystemMode
        {
            get;
            set;
        }

        [JsonPropertyName("canBePermanent")]
        public bool CanBePermanent
        {
            get;
            set;
        }

        [JsonPropertyName("canBeTemporary")]
        public bool CanBeTemporary
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
        [JsonPropertyName("timingMode")]
        public string TimingMode
        {
            get;
            set;
        }
    }
}