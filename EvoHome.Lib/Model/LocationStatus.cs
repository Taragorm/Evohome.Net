using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class LocationStatus
    {
        [JsonPropertyName("locationId")]
        public string LocationId
        {
            get;
            set;
        }

        [JsonPropertyName("gateways")]
        public List<GatewayStatus> Gateways
        {
            get;
            set;
        }
    }
}