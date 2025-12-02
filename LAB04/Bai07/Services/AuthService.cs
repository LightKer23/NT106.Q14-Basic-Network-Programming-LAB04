using Bai07.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07.Services
{
    public class AuthService
    {
        private readonly ApiClient _apiClient;
        public AuthService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task<ApiResult<AuthTokenResponse>> LoginAsync(string username, string password)
        {
            var form = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", "password")
            });

            var response = await _apiClient.PostFromAsync<AuthTokenResponse>("/auth/token", form);

            if (response.Success && response.Data != null)
            {
                _apiClient.SetToken(response.Data.token_type, response.Data.access_token);
            }

            return response;
        }

        public Task<ApiResult<UserInfo>> GetMeAsync()
        {
            return _apiClient.GetAsync<UserInfo>("/auth/me");
        }

        public async Task<ApiResult<UserInfo>> RegisterAsync(UserInfo userInfo)
        {
            var payload = new
            {
                username = userInfo.username,
                email = userInfo.email,
                password = userInfo.password,
                first_name = userInfo.first_name,
                last_name = userInfo.last_name,
                sex = userInfo.sex,
                birthday = userInfo.birthday?.ToString("yyyy-MM-dd"),
                language = userInfo.language,
                phone = userInfo.phone
            };

            return await _apiClient.PostJsonAsync<object, UserInfo>("/api/v1/user/signup", payload);
        }
    }
}
