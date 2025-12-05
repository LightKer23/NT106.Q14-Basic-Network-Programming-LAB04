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

        private static PagedResult<FoodItem> MapToPagedResult(DishListResponse<FoodItem> src)
        {
            var pg = src.pagination;
            var totalPages = (int)Math.Ceiling(pg.total / (double)pg.page_size);

            return new PagedResult<FoodItem>
            {
                Items = src.data,
                Page = pg.current,
                PageSize = pg.page_size,
                TotalCount = pg.total,
                TotalPages = totalPages
            };
        }

        public async Task<ApiResult<PagedResult<FoodItem>>> GetAllFoodsAsync(int page, int size)
        {
            var payload = new { current = page, pageSize = size };

            var apiRes = await _apiClient
                .PostJsonAsync<object, DishListResponse<FoodItem>>("/api/v1/monan/all", payload);

            if (!apiRes.Success || apiRes.Data == null)
                return ApiResult<PagedResult<FoodItem>>
                    .Fail(apiRes.ErrorMessage ?? "Không tải được danh sách cộng đồng.");

            var d = apiRes.Data;

            int totalPages = (int)Math.Ceiling((double)d.pagination.total / d.pagination.page_size);

            var paged = new PagedResult<FoodItem>
            {
                Items = d.data,
                Page = d.pagination.current,
                PageSize = d.pagination.page_size,
                TotalCount = d.pagination.total,
                TotalPages = totalPages
            };

            return ApiResult<PagedResult<FoodItem>>.Ok(paged);
        }

        public async Task<ApiResult<PagedResult<FoodItem>>> GetMyFoodsAsync(int page, int size)
        {
            var payload = new { current = page, pageSize = size };

            var apiRes = await _apiClient
                .PostJsonAsync<object, DishListResponse<FoodItem>>("/api/v1/monan/my-dishes", payload);

            if (!apiRes.Success || apiRes.Data == null)
                return ApiResult<PagedResult<FoodItem>>
                    .Fail(apiRes.ErrorMessage ?? "Không tải được danh sách cá nhân.");

            var paged = MapToPagedResult(apiRes.Data);
            return ApiResult<PagedResult<FoodItem>>.Ok(paged);
        }

        public Task<ApiResult<FoodItem>> GetFoodByIdAsync(int id)
        {
            return _apiClient.GetAsync<FoodItem>($"/api/v1/monan/{id}");
        }


        public Task<ApiResult<FoodItem>> AddFoodAsync(string name, int price, string? description, string? imageUrl, string? address)
        {
            var payload = new
            {
                ten_mon_an = name,
                gia = price,
                mo_ta = description,
                hinh_anh = imageUrl,
                dia_chi = address
            };

            return _apiClient.PostJsonAsync<object, FoodItem>("/api/v1/monan/add", payload);
        }

        public Task<ApiResult<FoodItem>> UpdateFoodAsync(int id, string name, int price, string? description, string? image, string? address)
        {
            var payload = new
            {
                ten_mon_an = name,
                gia = price,
                mo_ta = description,
                hinh_anh = image,
                dia_chi = address
            };

            return _apiClient.PostJsonAsync<object, FoodItem>($"/api/v1/monan/{id}", payload);
        }

        public Task<ApiResult<bool>> DeleteFoodAsync(int id)
        {
            return _apiClient.DeleteAsync($"/api/v1/monan/{id}");
        }

        public async Task<ApiResult<List<FoodItem>>> GetAllFoodsNoPagingAsync()
        {
            var allFoods = new List<FoodItem>();

            var firstPage = await GetAllFoodsAsync(1, 50);
            if (!firstPage.Success || firstPage.Data == null)
                return ApiResult<List<FoodItem>>.Fail(firstPage.ErrorMessage ?? "Không tải được dữ liệu.");

            allFoods.AddRange(firstPage.Data.Items);
            int totalPages = firstPage.Data.TotalPages;

            for (int p = 2; p <= totalPages; p++)
            {
                var pageResult = await GetAllFoodsAsync(p, 50);
                if (!pageResult.Success || pageResult.Data == null)
                    return ApiResult<List<FoodItem>>.Fail(pageResult.ErrorMessage ?? $"Không tải được trang {p}");

                allFoods.AddRange(pageResult.Data.Items);
            }

            return ApiResult<List<FoodItem>>.Ok(allFoods);
        }


    }
}
