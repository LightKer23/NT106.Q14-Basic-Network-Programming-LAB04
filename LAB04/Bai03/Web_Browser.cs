using HtmlAgilityPack;
using Microsoft.Web.WebView2.WinForms;
using System.Security.Policy;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Bai03
{
    public partial class Web_Browser : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public Web_Browser()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);

                string projectPath = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName;
                string logoPath = Path.Combine(projectPath, "uit_logo.png");

                if (File.Exists(logoPath))
                {
                    byte[] imageBytes = await File.ReadAllBytesAsync(logoPath);
                    string base64 = Convert.ToBase64String(imageBytes);

                    string htmlContent = $@"
                    <!DOCTYPE html>
                    <html>
                    <head>
                        <style>
                            body {{
                                display: flex;
                                justify-content: center;
                                align-items: center;
                                height: 100vh;
                                margin: 0;
                                background-color: #f0f0f0;
                            }}
                            img {{
                                max-width: 80%;
                                max-height: 80%;
                            }}
                        </style>
                    </head>
                    <body>
                        <img src='data:image/png;base64,{base64}' alt='UIT Logo' />
                    </body>
                    </html>";

                    webView21.CoreWebView2.NavigateToString(htmlContent);
                    return;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo WebView2: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtUrl.Text.Trim();

                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Vui lòng nhập URL!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (webView21.CoreWebView2 != null)
                {
                    webView21.CoreWebView2.Reload();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi reload: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtUrl.Text.Trim();

                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Vui lòng nhập URL!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "https://" + url;
                    txtUrl.Text = url;
                }

                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load trang: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDowFi_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtUrl.Text.Trim();

                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Không có URL để tải!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (url == "UIT Logo")
                {
                    MessageBox.Show("Không thể tải file HTML của logo local!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "HTML Files (*.html)|*.html|All Files (*.*)|*.*";
                saveDialog.DefaultExt = "html";
                saveDialog.FileName = "webpage.html";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string htmlContent = await httpClient.GetStringAsync(url);
                    await File.WriteAllTextAsync(saveDialog.FileName, htmlContent, System.Text.Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải file HTML: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDowRe_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtUrl.Text.Trim();

                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Không có URL để tải resources!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (url == "UIT Logo")
                {
                    MessageBox.Show("Không thể tải resources của logo local!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FolderBrowserDialog folderDialog = new FolderBrowserDialog();

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = folderDialog.SelectedPath;
                    string htmlContent = await httpClient.GetStringAsync(url);

                    var doc = new HtmlDocument();
                    doc.LoadHtml(htmlContent);

                    var imgNodes = doc.DocumentNode.SelectNodes("//img[@src]");

                    if (imgNodes == null || imgNodes.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hình ảnh nào trên trang web!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int downloaded = 0;
                    int failed = 0;

                    foreach (var img in imgNodes)
                    {
                        try
                        {
                            string imgUrl = img.GetAttributeValue("src", "");

                            if (string.IsNullOrEmpty(imgUrl))
                                continue;

                            if (!imgUrl.StartsWith("http"))
                            {
                                Uri baseUri = new Uri(url);
                                Uri absoluteUri = new Uri(baseUri, imgUrl);
                                imgUrl = absoluteUri.ToString();
                            }

                            string fileName = Path.GetFileName(new Uri(imgUrl).LocalPath);
                            if (string.IsNullOrEmpty(fileName) || fileName.Length > 50)
                                fileName = $"image_{downloaded}.jpg";

                            fileName = string.Join("_", fileName.Split(Path.GetInvalidFileNameChars()));
                            string filePath = Path.Combine(savePath, fileName);

                            byte[] imageBytes = await httpClient.GetByteArrayAsync(imgUrl);
                            await File.WriteAllBytesAsync(filePath, imageBytes);
                            downloaded++;
                        }
                        catch
                        {
                            failed++;
                        }
                    }
                    MessageBox.Show($"Hoàn thành!\nĐã tải: {downloaded} hình\nThất bại: {failed} hình\nThư mục: {savePath}",
                        "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải resources: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}