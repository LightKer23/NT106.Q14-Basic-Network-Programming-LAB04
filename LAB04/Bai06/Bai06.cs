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

            try
            {
                string url = txtURL.Text.Trim();
                string token = txtToken.Text.Trim();

                if (url == "" || token == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ URL và Token");
                    return;
                }

                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    MessageBox.Show("URL không hợp lệ");
                    return;
                }

                var service = new UserService(url);
                var result = await service.GetUserInfoAsync(token);

                if (!result.success)
                {
                    rtbShow.Text = result.message;
                    return;
                }

                var user = result.user;

                rtbShow.AppendText($"ID: {user.id}\n");
                rtbShow.AppendText($"Username: {user.username}\n");
                rtbShow.AppendText($"Full Name: {user.full_name}\n");
                rtbShow.AppendText($"Email: {user.email}\n");
                rtbShow.AppendText($"Disabled: {user.disabled}\n");
            }
            catch
            {
                rtbShow.Text = "Có lỗi xảy ra!";
            }
        }
    }
}
