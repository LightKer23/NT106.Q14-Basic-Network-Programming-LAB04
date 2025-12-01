using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai07.Models;

namespace Bai07.Services
{
    public class FoodService
    {
        private readonly ApiClient _apiClient;
        public FoodService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Task<ApiResult<PagedResult<FoodItem>>> GetAllFoodsAsync(int page, int size)
        {
            string url = $"/api/v1/monan/all?page={page}&size={size}";
            return _apiClient.GetAsync<PagedResult<FoodItem>>(url);
        }

        public Task<ApiResult<PagedResult<FoodItem>>> GetMyFoodsAsync(int page, int size) 
        {
            string url = $"/api/v1/monan/my-dishes?page={page}&size={size}";
            return _apiClient.GetAsync<PagedResult<FoodItem>>(url);
        }

        public Task<ApiResult<FoodItem>> AddFoodAsync(string name, string? imageURL)
        {
            var payload = new
            {
                name = name,
                image_url = imageURL
            };

            return _apiClient.PostJsonAsync<object, FoodItem>("/api/v1/monan", payload);
        }

        public Task<ApiResult<bool>> DeleteFoodAsync(int id)
        {
            string url = $"/api/v1/monan/{id}";
            return _apiClient.DeleteAsync(url);
        }

    }
}
