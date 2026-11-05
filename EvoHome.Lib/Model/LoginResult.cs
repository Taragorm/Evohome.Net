using Newtonsoft.Json;
using System;

namespace Evohome.Lib
{
    public class LoginResult
    {
        [JsonProperty("access_token")]
        public string Access_token
        {
            get;
            set;
        }
        [JsonProperty("token_type")]
        public string Token_type
        {
            get;
            set;
        }

        int _expires_in;
        [JsonProperty("expires_in")]
        public int Expires_in
        {
            get
            {
                return _expires_in;
            }

            set
            {
                _expires_in = value;
                ExpiryUtc = DateTime.UtcNow.AddSeconds(value - 10);
            }
        }

        [JsonIgnore]
        public bool HasExpired
        {
            get
            {
                return DateTime.UtcNow >= ExpiryUtc;
            }
        }

        [JsonIgnore]
        public DateTime ExpiryUtc
        {
            get;
            private set;
        }

        [JsonProperty("refresh_token")]
        public string Refresh_token
        {
            get;
            set;
        }

        [JsonProperty("scope")]
        public string Scope
        {
            get;
            set;
        }
    }
}