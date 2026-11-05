using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class AccountInfo
    {
        [JsonProperty("userId")]
        public string UserId
        {
            get;
            set;
        }
        [JsonProperty("username")]
        public string Username
        {
            get;
            set;
        }
        [JsonProperty("firstname")]
        public string Firstname
        {
            get;
            set;
        }
        [JsonProperty("lastname")]
        public string Lastname
        {
            get;
            set;
        }
        [JsonProperty("streetAddress")]
        public string StreetAddress
        {
            get;
            set;
        }
        [JsonProperty("city")]
        public string City
        {
            get;
            set;
        }
        [JsonProperty("postcode")]
        public string Postcode
        {
            get;
            set;
        }
        [JsonProperty("country")]
        public string Country
        {
            get;
            set;
        }
        [JsonProperty("language")]
        public string Language
        {
            get;
            set;
        }
    }
}