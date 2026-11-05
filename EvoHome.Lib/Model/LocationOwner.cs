using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class LocationOwner
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
    }
}