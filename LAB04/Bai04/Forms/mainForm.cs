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

namespace Bai04.Forms
{
    public partial class mainForm : Form
    {
        private readonly MovieScraper scraper = new();

        public mainForm()
        {
            InitializeComponent();
            this.Load += mainForm_Load;
        }

        private async void mainForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            progressBar1.Value = 0;

            var progress = new Progress<int>(p =>
            {
                if (p >= 0 && p <= 100)
                    progressBar1.Value = p;
            });

            var movies = await scraper.GetMovies(progress);

            foreach (var mv in movies)
            {
                var banner = new movieBanner(mv)
                {
                    Width = flowLayoutPanel1.Width - 25,
                    Margin = new Padding(4)
                };

                banner.BannerClick += Banner_Click;
                flowLayoutPanel1.Controls.Add(banner);
            }
        }

        private void Banner_Click(Movie mv)
        {
            new movieDetail(mv).Show();
        }
    }
}
