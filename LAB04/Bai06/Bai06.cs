namespace Bai06
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private async void btnLay_Click(object sender, EventArgs e)
        {
            rtbShow.Clear();

            string url = txtURL.Text.Trim();
            string token = txtToken.Text.Trim();

            if (url == "" || token == "")
            {
                rtbShow.Text = "Vui lòng nhập đầy đủ dữ liệu!";
                return;
            }

            if (string.IsNullOrWhiteSpace(url) || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                MessageBox.Show("Đường dẫn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var service = new UserService(url);
            var result = await service.GetUserInfoAsync(token);

            if (!result.success)
            {
                rtbShow.Text = "Lỗi khi gọi API:\n" + result.message;
                return;
            }

            var user = result.user;

            rtbShow.AppendText("=== THÔNG TIN USER ===\n");
            rtbShow.AppendText($"ID: {user.id}\n");
            rtbShow.AppendText($"Username: {user.username}\n");
            rtbShow.AppendText($"Full Name: {user.full_name}\n");
            rtbShow.AppendText($"Email: {user.email}\n");
            rtbShow.AppendText($"Disabled: {user.disabled}\n");
        }
    }
}
