using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class LocationInfo
    {
        [JsonPropertyName("locationId")]
        public string LocationId
        {
            get;
            set;
        }
        [JsonPropertyName("name")]
        public string Name
        {
            get;
            set;
        }
        [JsonPropertyName("streetAddress")]
        public string StreetAddress
        {
            get;
            set;
        }
        [JsonPropertyName("city")]
        public string City
        {
            get;
            set;
        }
        [JsonPropertyName("country")]
        public string Country
        {
            get;
            set;
        }
        [JsonPropertyName("postcode")]
        public string Postcode
        {
            get;
            set;
        }
        [JsonPropertyName("locationType")]
        public string LocationType
        {
            get;
            set;
        }
        [JsonPropertyName("useDaylightSaveSwitching")]
        public bool UseDaylightSaveSwitching
        {
            get;
            set;
        }
        [JsonPropertyName("timeZone")]
        public TimeZone TimeZone
        {
            get;
            set;
        }
        [JsonPropertyName("locationOwner")]
        public LocationOwner LocationOwner
        {
            get;
            set;
        }
    }
}