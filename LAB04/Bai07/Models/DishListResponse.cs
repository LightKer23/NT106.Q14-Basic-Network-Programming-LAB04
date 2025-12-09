namespace Bai07.Models
{
    public class DishListResponse<T>
    {
        public List<T> data { get; set; } = new();
        public PaginationShow? pagination { get; set; } = new();
    }
}
