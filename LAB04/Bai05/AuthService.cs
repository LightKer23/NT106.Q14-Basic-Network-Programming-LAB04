using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bai05
{
    internal class AuthService
    {
        private readonly string _url;

        public AuthService(string url)
        {
            _url = url;
        }

        public async Task<(bool success, string message)> LoginAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };

                var response = await client.PostAsync(_url, content);
                var json = await response.Content.ReadAsStringAsync();
                var obj = JObject.Parse(json);

                // Lỗi → trả về detail
                if (!response.IsSuccessStatusCode)
                {
                    string detail = obj["detail"]?.ToString();
                    return (false, detail);
                }

                // Thành công → ghép token type + token
                string tokenType = obj["token_type"]?.ToString();
                string accessToken = obj["access_token"]?.ToString();

                return (true, $"{tokenType}\n\n{accessToken}\n");
            }
        }
    }
}
