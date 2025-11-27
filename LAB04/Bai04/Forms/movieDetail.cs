using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai04.Data;
using Microsoft.Web.WebView2.Core;

namespace Bai04.Forms
{
    public partial class movieDetail : Form
    {
        private Movie Data;

        public movieDetail(Movie mv)
        {
            InitializeComponent();
            Data = mv;
            this.Text = mv.Title;
            this.Load += movieDetail_Load;
        }

        private async void movieDetail_Load(object? sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.Navigate(Data.DetailUrl);
        }
    }
}
