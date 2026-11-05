using System;
using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class ActiveFault
    {
        [JsonProperty("faultType")]
        public string FaultType
        { get; set; }

        [JsonProperty("since")]
        public string Since
        { get; set; }

        [JsonIgnore]
        public DateTime SinceAsDateTime
        {
            get { return DateTime.ParseExact(Since, "yyyy-MM-ddTHH:mm:ss.fff", null); }
        }
        
    }
}
