using System;
using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class ActiveFault
    {
        [JsonPropertyName("faultType")]
        public string FaultType
        { get; set; }

        [JsonPropertyName("since")]
        public string Since
        { get; set; }

        [JsonIgnore]
        public DateTime SinceAsDateTime
        {
            get { return DateTime.ParseExact(Since, "yyyy-MM-ddTHH:mm:ss.fff", null); }
        }
        
    }
}
