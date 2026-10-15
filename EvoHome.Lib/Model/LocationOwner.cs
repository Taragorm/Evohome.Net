using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class LocationOwner
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
    }
}