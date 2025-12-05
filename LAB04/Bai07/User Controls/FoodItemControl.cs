using Bai07.Models;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace Bai07
{
    public partial class FoodItemControl : UserControl
    {
        private const string BaseUrl = "https://nt106.uitiot.vn";
        private static readonly HttpClient httpClient = new HttpClient();

        public FoodItemControl()
        {
            InitializeComponent();
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void SetData(FoodItem food)
        {
            if (food == null) return;

            lblNameFood.Text = food.ten_mon_an ?? "Chưa có tên";
            lblPrice.Text = $"{food.gia:N0} VNĐ";
            lblAddress.Text = (food.dia_chi ?? "Chưa có địa chỉ");
            lblContributor.Text = (food.nguoi_dong_gop ?? "Ẩn danh");

            SetImageFromUrl(food.hinh_anh);
        }

        private async void SetImageFromUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                DisposeCurrentImage();
                return;
            }

            if (Path.IsPathRooted(url) && !url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    DisposeCurrentImage();
                    pbImage.Image = Image.FromFile(url);
                }
                catch (Exception ex)
                {
                    DisposeCurrentImage();
                    System.Diagnostics.Debug.WriteLine("Lỗi load ảnh local: " + ex.Message);
                }
                return;
            }

            if (!url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                if (!url.StartsWith("/")) url = "/" + url;
                url = BaseUrl + url;
            }

            try
            {
                var bytes = await httpClient.GetByteArrayAsync(url);
                using (var ms = new MemoryStream(bytes))
                {
                    var img = Image.FromStream(ms);

                    DisposeCurrentImage();
                    pbImage.Image = img;
                }
            }
            catch (Exception ex)
            {
                DisposeCurrentImage();
                System.Diagnostics.Debug.WriteLine("Lỗi load ảnh http: " + ex.Message);
            }
        }

        private void DisposeCurrentImage()
        {
            if (pbImage.Image != null)
            {
                pbImage.Image.Dispose();
                pbImage.Image = null;
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            DisposeCurrentImage();
            base.OnHandleDestroyed(e);
        }
    }
}
