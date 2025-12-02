using Bai07.Models;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Bai07.Services
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;
        public ApiClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://nt106.uitiot.vn");
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public void SetToken(string tokenType, string accessToken)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
        }

        public void ClearToken()
        {
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
        #region Helpers

        public async Task<ApiResult<T>> PostFromAsync<T>(string url, FormUrlEncodedContent content)
        {
            try
            {
                var resp = await _httpClient.PostAsync(url, content);
                var body = await resp.Content.ReadAsStringAsync();

                if (!resp.IsSuccessStatusCode)
                    return ApiResult<T>.Fail(body);

                var data = JsonSerializer.Deserialize<T>(body, _jsonOptions);
                return ApiResult<T>.Ok(data!);
            }
            catch (Exception ex)
            {
                return ApiResult<T>.Fail(ex.Message);
            }
        }

        public async Task<ApiResult<T>> GetAsync<T>(string url)
        {
            try
            {
                var resp = await _httpClient.GetAsync(url);
                var body = await resp.Content.ReadAsStringAsync();

                if (!resp.IsSuccessStatusCode)
                    return ApiResult<T>.Fail(ParseErrorMessage(body));

                var data = JsonSerializer.Deserialize<T>(body, _jsonOptions);
                return ApiResult<T>.Ok(data!);
            }
            catch (Exception ex)
            {
                return ApiResult<T>.Fail(ex.Message);
            }
        }

        public async Task<ApiResult<TRes>> PostJsonAsync<TReq, TRes>(string url, TReq payload)
        {
            try
            {
                var json = JsonSerializer.Serialize(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var resp = await _httpClient.PostAsync(url, content);
                var body = await resp.Content.ReadAsStringAsync();

                if (!resp.IsSuccessStatusCode)
                    return ApiResult<TRes>.Fail(body);

                try
                {
                    var data = JsonSerializer.Deserialize<TRes>(body, _jsonOptions);
                    return ApiResult<TRes>.Ok(data!);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(body, "JSON trả về khi thêm món");
                    return ApiResult<TRes>.Fail("Lỗi parse JSON: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                return ApiResult<TRes>.Fail(ex.Message);
            }
        }

        public async Task<ApiResult<bool>> DeleteAsync(string url)
        {
            try
            {
                var resp = await _httpClient.DeleteAsync(url);
                var body = await resp.Content.ReadAsStringAsync();
                if (!resp.IsSuccessStatusCode)
                    return ApiResult<bool>.Fail(body);
                return ApiResult<bool>.Ok(true);
            }
            catch (Exception ex)
            {
                return ApiResult<bool>.Fail(ex.Message);
            }
        }

        private string ParseErrorMessage(string responseBody)
        {
            try
            {
                using var doc = JsonDocument.Parse(responseBody);
                if (doc.RootElement.TryGetProperty("error", out var errorElement))
                {
                    return errorElement.GetString() ?? "Unknown error";
                }
            }
            catch
            {
            }
            return "Unknown error";
        }
        #endregion
    }
}
