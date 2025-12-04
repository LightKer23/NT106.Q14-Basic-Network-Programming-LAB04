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

            try
            {
                string url = txtURL.Text.Trim();
                string username = txtUser.Text.Trim();
                string password = txtPass.Text.Trim();

                if (url == "" || username == "" || password == "")
                {
                    rtbShow.AppendText("Vui lòng nhập đầy đủ dữ liệu!");
                    return;
                }

                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    MessageBox.Show("URL không hợp lệ", "Lỗi");
                    return;
                }

                var service = new AuthService(url);
                var result = await service.LoginAsync(username, password);

                if (result.success)
                {
                    rtbShow.AppendText("Đăng nhập thành công!\n\n");
                    rtbShow.AppendText(result.message);
                }
                else
                {
                    rtbShow.AppendText("Đăng nhập thất bại!\n");
                    rtbShow.AppendText(result.message);
                }
            }
            catch
            {
                rtbShow.AppendText("Có lỗi xảy ra!");
            }
        }
    }
}
