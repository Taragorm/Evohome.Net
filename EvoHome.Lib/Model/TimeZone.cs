using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class TimeZone
    {
        [JsonPropertyName("timeZoneId")]
        public string TimeZoneId
        {
            get;
            set;
        }
        [JsonPropertyName("displayName")]
        public string DisplayName
        {
            get;
            set;
        }
        [JsonPropertyName("offsetMinutes")]
        public int OffsetMinutes
        {
            get;
            set;
        }
        [JsonPropertyName("currentOffsetMinutes")]
        public int CurrentOffsetMinutes
        {
            get;
            set;
        }
        [JsonPropertyName("supportsDaylightSaving")]
        public bool SupportsDaylightSaving
        {
            get;
            set;
        }
    }
}