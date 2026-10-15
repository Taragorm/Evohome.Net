using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class StateStatus
    {
        [JsonPropertyName("state")]
        public string State
        {
            get;
            set;
        }

        [JsonPropertyName("mode")]
        public string Mode
        {
            get;
            set;
        }
    }
}