using Bai07.Forms;
using Bai07.Models;
using Bai07.Services;
using Bai07.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class MainForm : Form
    {
        private int _pageSize = 5;
        private int _pageAll = 1;
        private int _totalPagesAll = 1;
        private int _pageMy = 1;
        private int _totalPagesMy = 1;
        private bool _isUpdatingPageCombo = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (pnlAllList.Controls.Contains(pnlMyList))
            {
                pnlAllList.Controls.Remove(pnlMyList);
                tlpContent.Controls.Add(pnlMyList, 0, 1);
            }

            pnlAllList.Dock = DockStyle.Fill;
            pnlMyList.Dock = DockStyle.Fill;

            if (CurrentUser.User != null)
            {
                tsslLabel.Text = "Welcome,";
                tsslName.Text = CurrentUser.User.last_name;
            }
            else
            {
                tsslLabel.Text = "Welcome";
                tsslName.Text = "";
            }

            cboPageSize.SelectedIndex = 0;

            await LoadAllFoodsAsync();
        }

        private async Task LoadAllFoodsAsync()
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

            var result = await Program.FoodService.GetAllFoodsAsync(_pageAll, _pageSize);

            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

            if (!result.Success || result.Data == null)
            {
                MessageBox.Show(result.ErrorMessage ?? "Không tải được dữ liệu cộng đồng");
                return;
            }

            _totalPagesAll = result.Data.TotalPages;
            UpdatePageCombo();

            RenderAllFoods(result.Data.Items);
        }

        private async Task LoadMyFoodsAsync()
        {
            if (string.IsNullOrEmpty(CurrentUser.User?.token))
            {
                MessageBox.Show("Lỗi token! Bạn cần đăng nhập lại.", "Lỗi");
                return;
            }

            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

            var result = await Program.FoodService.GetMyFoodsAsync(_pageMy, _pageSize);

            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

            if (!result.Success || result.Data == null)
            {
                MessageBox.Show($"Lỗi: {result.ErrorMessage ?? "Không tải được danh sách cá nhân"}",
                    "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _totalPagesMy = result.Data.TotalPages;
            UpdatePageCombo();

            RenderMyFoods(result.Data.Items ?? new List<FoodItem>());
        }

        private void ClearAndDisposeControls(FlowLayoutPanel panel)
        {
            foreach (Control c in panel.Controls)
                c.Dispose();

            panel.Controls.Clear();
        }

        private void RenderAllFoods(List<FoodItem> items)
        {
            pnlAllList.BringToFront();
            ClearAndDisposeControls(flpAllFoods);

            foreach (var f in items)
            {
                var card = new FoodItemControl();
                card.SetData(f);
                flpAllFoods.Controls.Add(card);
            }
        }

        private void RenderMyFoods(List<FoodItem> items)
        {
            pnlMyList.BringToFront();
            ClearAndDisposeControls(flpMyFoods);

            foreach (var f in items)
            {
                var card = new FoodItemControl();
                card.SetData(f);
                flpMyFoods.Controls.Add(card);
            }
        }

        private void UpdatePageCombo()
        {
            _isUpdatingPageCombo = true;
            try
            {
                cboPage.Items.Clear();

                int totalPages;
                int currentPage;

                if (tabMain.SelectedTab == tbAll)
                {
                    totalPages = _totalPagesAll;
                    currentPage = _pageAll;
                }
                else
                {
                    totalPages = _totalPagesMy;
                    currentPage = _pageMy;
                }

                if (totalPages <= 0)
                {
                    cboPage.Enabled = false;
                    cboPage.Text = "0";
                    return;
                }

                cboPage.Enabled = true;

                for (int i = 1; i <= totalPages; i++)
                    cboPage.Items.Add(i);

                if (currentPage >= 1 && currentPage <= totalPages)
                    cboPage.SelectedItem = currentPage;
                else
                    cboPage.SelectedIndex = 0;
            }
            finally
            {
                _isUpdatingPageCombo = false;
            }
        }

        private async void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tbAll)
                await LoadAllFoodsAsync();
            else
                await LoadMyFoodsAsync();
        }

        private async void cboPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingPageCombo) return;
            if (cboPage.SelectedItem == null) return;

            int newPage = (int)cboPage.SelectedItem;

            if (tabMain.SelectedTab == tbAll)
                _pageAll = newPage;
            else
                _pageMy = newPage;

            await ReloadCurrentTabAsync();
        }

        private async void cboPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pageSize = int.Parse(cboPageSize.SelectedItem!.ToString()!);
            _pageAll = 1;
            _pageMy = 1;

            await ReloadCurrentTabAsync();
        }

        private async Task ReloadCurrentTabAsync()
        {
            if (tabMain.SelectedTab == tbAll)
                await LoadAllFoodsAsync();
            else
                await LoadMyFoodsAsync();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new AddDishForm())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    _pageAll = 1;
                    await ReloadCurrentTabAsync();
                }
            }
        }

        private void tsslLogOut_Click(object sender, EventArgs e)
        {
            CurrentUser.ClearUser();
            this.Hide();
            new LoginForm().Show();
            this.Close();
        }

        private async void btnRandom_Click(object sender, EventArgs e)
        {
            var allFoods = await Program.FoodService.GetAllFoodsNoPagingAsync();

            if (!allFoods.Success || allFoods.Data == null || allFoods.Data.Count == 0)
            {
                MessageBox.Show("Không có món nào để tìm!");
                return;
            }

            var rnd = new Random();
            int idx = rnd.Next(0, allFoods.Data.Count);
            var chosen = allFoods.Data[idx];

            using (var frm = new RandomFoodForm(chosen))
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
            }
        }
    }
}
