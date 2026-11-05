using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Evohome.Lib
{
    public class Location
    {
        [JsonProperty("locationInfo")]
        public LocationInfo LocationInfo
        {
            get;
            set;
        }

        List<Gateway> _gateways;
        [JsonProperty("gateways")]
        public List<Gateway> Gateways
        {
            get
            {
                return _gateways;
            }

            set
            {
                foreach (var g in value)
                    g.Parent = this;
                _gateways = value;
            }
        }

        [JsonIgnore]
        public Controller Controller
        {
            get;
            set;
        }

        public async Task UpdateStatus()
        {
            var status = await Controller.MakeGetRequest<LocationStatus>(string.Format(Controller.RootUrl + "/WebAPI/emea/api/v1/location/{0}/status?includeTemperatureControlSystems=True", LocationInfo.LocationId));
            foreach (var g in Gateways)
                g.UpdateStatus((
                    from gs in status.Gateways
                    where gs.GatewayId == g.GatewayInfo.GatewayId
                    select gs).FirstOrDefault());
        }

        public async Task<JObject> GetStatusRaw()
        {
            return await Controller.MakeGetRequest<JObject>(
                        string.Format(Controller.RootUrl + "/WebAPI/emea/api/v1/location/{0}/status?includeTemperatureControlSystems=True", 
                        LocationInfo.LocationId)
                        );
        }

    }
}