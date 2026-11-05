using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class StateStatus
    {
        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }

        [JsonProperty("mode")]
        public string Mode
        {
            get;
            set;
        }
    }
}