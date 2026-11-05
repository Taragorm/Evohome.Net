using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class TimeZone
    {
        [JsonProperty("timeZoneId")]
        public string TimeZoneId
        {
            get;
            set;
        }
        [JsonProperty("displayName")]
        public string DisplayName
        {
            get;
            set;
        }
        [JsonProperty("offsetMinutes")]
        public int OffsetMinutes
        {
            get;
            set;
        }
        [JsonProperty("currentOffsetMinutes")]
        public int CurrentOffsetMinutes
        {
            get;
            set;
        }
        [JsonProperty("supportsDaylightSaving")]
        public bool SupportsDaylightSaving
        {
            get;
            set;
        }
    }
}