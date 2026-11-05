using Newtonsoft.Json;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class LocationStatus
    {
        [JsonProperty("locationId")]
        public string LocationId
        {
            get;
            set;
        }

        [JsonProperty("gateways")]
        public List<GatewayStatus> Gateways
        {
            get;
            set;
        }
    }
}