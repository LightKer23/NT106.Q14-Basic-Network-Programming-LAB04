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
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10);
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", token);

                    HttpResponseMessage response;

                    try
                    {
                        response = await client.GetAsync(_url);
                    }
                    catch
                    {
                        return (false, "Không thể kết nối API", null);
                    }

                    string json = await response.Content.ReadAsStringAsync();

                    MessageBox.Show(json);

                    if (!response.IsSuccessStatusCode)
                        return (false, "API trả về lỗi", null);

                    try
                    {
                        var user = JsonConvert.DeserializeObject<UserResponse>(json);
                        if (user == null)
                            return (false, "Dữ liệu trả về không hợp lệ", null);

                        return (true, "OK", user);
                    }
                    catch
                    {
                        return (false, "Lỗi khi đọc dữ liệu", null);
                    }
                }
            }
            catch
            {
                return (false, "Lỗi không xác định", null);
            }
        }

    }
}
