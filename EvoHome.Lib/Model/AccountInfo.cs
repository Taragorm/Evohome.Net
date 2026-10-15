using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class AccountInfo
    {
        [JsonPropertyName("userId")]
        public string UserId
        {
            get;
            set;
        }
        [JsonPropertyName("username")]
        public string Username
        {
            get;
            set;
        }
        [JsonPropertyName("firstname")]
        public string Firstname
        {
            get;
            set;
        }
        [JsonPropertyName("lastname")]
        public string Lastname
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
        [JsonPropertyName("postcode")]
        public string Postcode
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
        [JsonPropertyName("language")]
        public string Language
        {
            get;
            set;
        }
    }
}