using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bai06
{
    internal class UserService
    {
        private readonly string _url;

        public UserService(string url)
        {
            _url = url;
        }

        public async Task<(bool success, string message, UserResponse user)> GetUserInfoAsync(string token)
        {
            using (var client = new HttpClient())
            {
                // Gửi token vào Authorization
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);

                var response = await client.GetAsync(_url);
                var json = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    return (false, json, null);

                var user = JsonConvert.DeserializeObject<UserResponse>(json);

                return (true, "OK", user);
            }
        }
    }
}
