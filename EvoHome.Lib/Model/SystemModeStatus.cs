using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class SystemModeStatus
    {
        [JsonPropertyName("mode")]
        public string Mode
        {
            get;
            set;
        }
        [JsonPropertyName("isPermanent")]
        public bool IsPermanent
        {
            get;
            set;
        }
        [JsonPropertyName("timeUntil")]
        public string TimeUntil
        {
            get;
            set;
        }
    }
}