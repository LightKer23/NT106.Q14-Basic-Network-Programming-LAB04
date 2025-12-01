using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07.Models
{
    public class FoodItem
    {
        public int id { get; set; }
        public string ten_mon_an { get; set; } = string.Empty;
        public int gia { get; set; }
        public string? mo_ta { get; set; }
        public string? hinh_anh { get; set; }
        public string? dia_chi { get; set; }
        public string? nguoi_dong_gop { get; set; }
    }
}
