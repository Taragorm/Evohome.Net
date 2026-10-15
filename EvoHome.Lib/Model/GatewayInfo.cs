using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class GatewayInfo
    {
        [JsonPropertyName("gatewayId")]
        public string GatewayId
        {
            get;
            set;
        }
        [JsonPropertyName("mac")]
        public string Mac
        {
            get;
            set;
        }
        [JsonPropertyName("crc")]
        public string Crc
        {
            get;
            set;
        }
        [JsonPropertyName("isWiFi")]
        public bool IsWiFi
        {
            get;
            set;
        }
    }
}