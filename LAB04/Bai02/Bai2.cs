using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Bai02 
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();
            string filePath = txtFilePath.Text.Trim();


            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ URL và đường dẫn lưu file!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Uri uriResult;
            bool isValidUrl = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (!isValidUrl)
            {
                MessageBox.Show("URL không hợp lệ! Vui lòng nhập đúng định dạng (VD: https://uit.edu.vn)", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtURL.Focus();
                return;
            }

            if (filePath.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
            {
                MessageBox.Show("Đường dẫn hoặc tên file chứa ký tự không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilePath.Focus();
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnDownload.Enabled = false;

                WebClient myClient = new WebClient();

                myClient.DownloadFile(url, filePath);

                StreamReader reader = new StreamReader(filePath);
                string content = reader.ReadToEnd();
                reader.Close();

                rtbContent.Text = content;

                MessageBox.Show("Đã tải về và lưu thành công tại: " + filePath, "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trang: " + ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnDownload.Enabled = true;
            }
        }
       

      
    }
}