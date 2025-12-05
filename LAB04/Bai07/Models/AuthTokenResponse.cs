using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bai07.Models
{
    public class AuthTokenResponse
    {
        [JsonPropertyName("access_token")]
        public string access_token { get; set; } = string.Empty;

        [JsonPropertyName("token_type")]
        public string token_type { get; set; } = string.Empty;

        [JsonPropertyName("expires_in")]
        public int expires_in { get; set; }
    }
}
