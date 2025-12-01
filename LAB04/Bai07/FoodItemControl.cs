using Bai07.Models;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class FoodItemControl : UserControl
    {
        public FoodItemControl()
        {
            InitializeComponent();
        }

        public string FoodName
        {
            get => lblNameFood.Text;
            set => lblNameFood.Text = value;
        }

        public string Price
        {
            get => lblPrice.Text;
            set => lblPrice.Text = value;
        }

        public string Address
        {
            get => lblAddress.Text;
            set => lblAddress.Text = value;
        }

        public string Contributor
        {
            get => lblContributor.Text;
            set => lblContributor.Text = value;
        }

        public void SetData(FoodItem food)
        {
            FoodName = food.ten_mon_an;
            Price = $"Giá: {food.gia}";
            Address = $"Địa chỉ: {food.dia_chi}";
            Contributor = $"Đóng góp: {food.nguoi_dong_gop}";
            SetImageFromUrl(food.hinh_anh);
        }

        public void SetImageFromUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                pbImage.Image = null;
                return;
            }

            try
            {
                pbImage.Load(url); 
            }
            catch
            {
                pbImage.Image = null;
            }
        }
    }
}
