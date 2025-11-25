using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            rtbShow.Clear();

            string url = txtURL.Text.Trim();
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (url == "" || username == "" || password == "")
            {
                rtbShow.AppendText("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            var service = new AuthService(url);
            var result = await service.LoginAsync(username, password);

            if (result.success)
            {
                rtbShow.AppendText(result.message);
                rtbShow.AppendText("\nĐăng nhập thành công!");
            }
            else
            {
                rtbShow.AppendText("Đăng nhập thất bại!\n");
                rtbShow.AppendText("Lỗi: " + result.message);
            }
        }
    }
}
