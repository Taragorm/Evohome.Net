using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class SystemModeStatus
    {
        [JsonProperty("mode")]
        public string Mode
        {
            get;
            set;
        }
        [JsonProperty("isPermanent")]
        public bool IsPermanent
        {
            get;
            set;
        }
        [JsonProperty("timeUntil")]
        public string TimeUntil
        {
            get;
            set;
        }
    }
}