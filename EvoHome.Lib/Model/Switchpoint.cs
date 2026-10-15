using System.Text.Json.Serialization;
using System;

namespace Evohome.Lib
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Currently missing information for DhwState
    /// </remarks>
    public class Switchpoint
    {
        [JsonPropertyName("temperature")]
        public double Temperature
        {
            get;
            set;
        }
        /// <summary>
        /// HH:mm:ss format
        /// </summary>
        [JsonPropertyName("timeOfDay")]
        public string TimeOfDay
        {
            get;
            set;
        }

        [JsonIgnore]
        public DateTime TimeAsDateTime
        {
            get { return DateTime.ParseExact(TimeOfDay, "HH:mm:ss", null); }
            set { TimeOfDay = value.ToString("HH:mm:ss"); }
        }
        [JsonIgnore]
        public TimeSpan Time
        {
            get { return TimeAsDateTime.TimeOfDay; }
        }
    }
}