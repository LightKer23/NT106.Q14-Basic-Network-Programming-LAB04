using System.Net;

namespace Bai01
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private string getHTML(string szURL)
        {
            try
            {
                WebRequest request = WebRequest.Create(szURL);

                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();

                response.Close();

                return responseFromServer;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!");
                txtURL.Focus();
                return;
            }

            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (!result)
            {
                MessageBox.Show("URL không hợp lệ! Vui lòng nhập đầy đủ (ví dụ: https://uit.edu.vn)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnGet.Enabled = false;
                rtbContent.Clear();
                rtbContent.Text = getHTML(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải trang: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnGet.Enabled = true;
            }
        }
    }
}
