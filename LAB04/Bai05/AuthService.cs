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
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10);

                    var content = new MultipartFormDataContent
            {
                { new StringContent(username), "username" },
                { new StringContent(password), "password" }
            };

                    HttpResponseMessage response;

                    try
                    {
                        response = await client.PostAsync(_url, content);
                    }
                    catch
                    {
                        return (false, "Không thể kết nối API");
                    }

                    string json = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        try
                        {
                            var obj = JObject.Parse(json);
                            string detail = obj["detail"]?.ToString() ?? "Lỗi đăng nhập";
                            return (false, detail);
                        }
                        catch
                        {
                            return (false, "Lỗi phản hồi từ server");
                        }
                    }
                    try
                    {
                        var obj = JObject.Parse(json);
                        string tokenType = obj["token_type"]?.ToString();
                        string accessToken = obj["access_token"]?.ToString();

                        if (tokenType == null || accessToken == null)
                            return (false, "Dữ liệu không hợp lệ");

                        return (true, $"{tokenType}\n\n{accessToken}");
                    }
                    catch
                    {
                        return (false, "Lỗi đọc dữ liệu");
                    }
                }
            }
            catch
            {
                return (false, "Lỗi không xác định");
            }
        }

    }
}
