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
        private int _page = 1;
        private int _pageSize = 5;
        private int _totalPages = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User != null)
                tsslLabel.Text = $"Welcome, {CurrentUser.User.last_name}";
            else
                tsslLabel.Text = "Welcome";

            cboPageSize.Items.AddRange(new object[] { 5, 10, 20 });
            cboPageSize.SelectedIndex = 0;

            await LoadAllFoodsAsync();
        }

        private async Task LoadAllFoodsAsync()
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

            var result = await Program.FoodService.GetAllFoodsAsync(_page, _pageSize);

            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

            if (!result.Success || result.Data == null)
            {
                MessageBox.Show(result.ErrorMessage ?? "Không tải được dữ liệu cộng đồng");
                return;
            }

            _totalPages = result.Data.TotalPages;
            UpdatePageCombo();

            RenderAllFoods(result.Data.Items);
        }

        private async Task LoadMyFoodsAsync()
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

            var result = await Program.FoodService.GetMyFoodsAsync(_page, _pageSize);

            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

            if (!result.Success || result.Data == null)
            {
                MessageBox.Show(result.ErrorMessage ?? "Không tải được danh sách cá nhân");
                return;
            }

            _totalPages = result.Data.TotalPages;
            UpdatePageCombo();

            RenderMyFoods(result.Data.Items);
        }

        private void RenderAllFoods(List<FoodItem> items)
        {
            pnlAllList.BringToFront();
            flpAllFoods.Controls.Clear();

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
            flpMyFoods.Controls.Clear();

            foreach (var f in items)
            {
                var card = new FoodItemControl();
                card.SetData(f);
                flpMyFoods.Controls.Add(card);
            }
        }

        private void UpdatePageCombo()
        {
            cboPage.Items.Clear();
            for (int i = 1; i <= _totalPages; i++)
                cboPage.Items.Add(i);

            if (_page <= _totalPages)
                cboPage.SelectedItem = _page;
            else
                cboPage.SelectedIndex = 0;
        }

        private async void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tbAll)
            {
                await LoadAllFoodsAsync();
            }
            else
            {
                await LoadMyFoodsAsync();
            }
        }

        private async void cboPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _page = int.Parse(cboPage.SelectedItem!.ToString()!);
            await ReloadCurrentTabAsync();
        }

        private async void cboPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pageSize = int.Parse(cboPageSize.SelectedItem!.ToString()!);
            _page = 1;
            await ReloadCurrentTabAsync();
        }

        private async Task ReloadCurrentTabAsync()
        {
            if (tabMain.SelectedTab == tbAll)
                await LoadAllFoodsAsync();
            else
                await LoadMyFoodsAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new AddDishForm())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    _page = 1;
                    ReloadCurrentTabAsync(); 
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
                MessageBox.Show("Không có món nào để random!");
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
