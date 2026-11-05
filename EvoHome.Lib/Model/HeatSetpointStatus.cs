using System;
using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class HeatSetpointStatus
    {
        [JsonProperty("targetTemperature")]
        public double TargetTemperature
        {
            get;
            set;
        }

        [JsonProperty("setpointMode")]
        public string SetpointMode
        {
            get;
            set;
        }

        [JsonProperty("until")]
        public DateTime Until
        {
            get;
            set;
        } = DateTime.MaxValue;


    }
}