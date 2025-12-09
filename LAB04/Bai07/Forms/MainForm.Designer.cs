namespace Bai07
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblBanner = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnRandom = new Button();
            tlpContent = new TableLayoutPanel();
            tabMain = new TabControl();
            tbAll = new TabPage();
            tbMine = new TabPage();
            pnlAllList = new Panel();
            pnlMyList = new Panel();
            flpMyFoods = new FlowLayoutPanel();
            flpAllFoods = new FlowLayoutPanel();
            pnlFooter = new Panel();
            cboPageSize = new ComboBox();
            cboPage = new ComboBox();
            lblPageSize = new Label();
            lblPage = new Label();
            statusStrip1 = new StatusStrip();
            tsslLabel = new ToolStripStatusLabel();
            tsslName = new ToolStripStatusLabel();
            tsslLogOut = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tlpMain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tlpContent.SuspendLayout();
            tabMain.SuspendLayout();
            pnlAllList.SuspendLayout();
            pnlMyList.SuspendLayout();
            pnlFooter.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.0150375F));
            tlpMain.Controls.Add(panel1, 0, 0);
            tlpMain.Controls.Add(flowLayoutPanel1, 0, 1);
            tlpMain.Controls.Add(tlpContent, 0, 2);
            tlpMain.Controls.Add(pnlFooter, 0, 3);
            tlpMain.Controls.Add(statusStrip1, 0, 4);
            tlpMain.Location = new Point(1, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 5;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 64.77273F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35.227272F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 443F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpMain.Size = new Size(622, 647);
            tlpMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblBanner);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 85);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(314, 41);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 3;
            label2.Text = "Phiên bản số 4";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eat_2411129_640;
            pictureBox1.Location = new Point(106, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblBanner
            // 
            lblBanner.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBanner.ForeColor = Color.FromArgb(64, 64, 64);
            lblBanner.Location = new Point(205, 6);
            lblBanner.Name = "lblBanner";
            lblBanner.Size = new Size(261, 46);
            lblBanner.TabIndex = 1;
            lblBanner.Text = "HÔM NAY ĂN GÌ?";
            lblBanner.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnRandom);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 94);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(616, 43);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(493, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.No;
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm món ăn";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRandom
            // 
            btnRandom.Anchor = AnchorStyles.None;
            btnRandom.BackColor = Color.White;
            btnRandom.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnRandom.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRandom.Location = new Point(367, 3);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(120, 40);
            btnRandom.TabIndex = 3;
            btnRandom.Text = "Tìm món ăn";
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 1;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpContent.Controls.Add(tabMain, 0, 0);
            tlpContent.Controls.Add(pnlAllList, 0, 1);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(3, 143);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 2;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 7.772021F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 92.22798F));
            tlpContent.Size = new Size(616, 437);
            tlpContent.TabIndex = 4;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tbAll);
            tabMain.Controls.Add(tbMine);
            tabMain.Location = new Point(3, 3);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(250, 24);
            tabMain.TabIndex = 0;
            tabMain.SelectedTab = tbAll;
            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
            // 
            // tbAll
            // 
            tbAll.Location = new Point(4, 29);
            tbAll.Name = "tbAll";
            tbAll.Padding = new Padding(3);
            tbAll.Size = new Size(242, 0);
            tbAll.TabIndex = 0;
            tbAll.Text = "Cộng đồng";
            tbAll.UseVisualStyleBackColor = true;
            // 
            // tbMine
            // 
            tbMine.Location = new Point(4, 29);
            tbMine.Name = "tbMine";
            tbMine.Padding = new Padding(3);
            tbMine.Size = new Size(242, 0);
            tbMine.TabIndex = 1;
            tbMine.Text = "Cá nhân";
            tbMine.UseVisualStyleBackColor = true;
            // 
            // pnlAllList
            // 
            pnlAllList.AutoScroll = true;
            pnlAllList.BringToFront();
            pnlAllList.Controls.Add(pnlMyList);
            pnlAllList.Controls.Add(flpAllFoods);
            pnlAllList.Dock = DockStyle.Fill;
            pnlAllList.Location = new Point(3, 36);
            pnlAllList.Name = "pnlAllList";
            pnlAllList.Size = new Size(610, 398);
            pnlAllList.TabIndex = 1;
            // 
            // pnlMyList
            // 
            pnlMyList.AutoScroll = true;
            pnlMyList.Controls.Add(flpMyFoods);
            pnlMyList.Dock = DockStyle.Fill;
            pnlMyList.Location = new Point(0, 0);
            pnlMyList.Name = "pnlMyList";
            pnlMyList.Size = new Size(610, 398);
            pnlMyList.TabIndex = 1;
            pnlMyList.Visible = false;
            // 
            // flpMyFoods
            // 
            flpMyFoods.AutoSize = true;
            flpMyFoods.Dock = DockStyle.Top;
            flpMyFoods.FlowDirection = FlowDirection.TopDown;
            flpMyFoods.Location = new Point(0, 0);
            flpMyFoods.Name = "flpMyFoods";
            flpMyFoods.Size = new Size(610, 0);
            flpMyFoods.TabIndex = 0;
            flpMyFoods.WrapContents = false;
            // 
            // flpAllFoods
            // 
            flpAllFoods.AutoSize = true;
            flpAllFoods.Dock = DockStyle.Top;
            flpAllFoods.FlowDirection = FlowDirection.TopDown;
            flpAllFoods.Location = new Point(0, 0);
            flpAllFoods.Name = "flpAllFoods";
            flpAllFoods.Size = new Size(610, 0);
            flpAllFoods.TabIndex = 0;
            flpAllFoods.WrapContents = false;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(cboPageSize);
            pnlFooter.Controls.Add(cboPage);
            pnlFooter.Controls.Add(lblPageSize);
            pnlFooter.Controls.Add(lblPage);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.Location = new Point(3, 586);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(616, 32);
            pnlFooter.TabIndex = 5;
            // 
            // cboPageSize
            // 
            cboPageSize.FormattingEnabled = true;
            cboPageSize.Items.AddRange(new object[] { "5", "10", "20" });
            cboPageSize.Location = new Point(552, 2);
            cboPageSize.Name = "cboPageSize";
            cboPageSize.Size = new Size(47, 28);
            cboPageSize.TabIndex = 3;
            cboPageSize.SelectedIndex = 0;
            cboPageSize.SelectedIndexChanged += cboPageSize_SelectedIndexChanged;
            // 
            // cboPage
            // 
            cboPage.FormattingEnabled = true;
            cboPage.Location = new Point(391, 1);
            cboPage.Name = "cboPage";
            cboPage.Size = new Size(47, 28);
            cboPage.TabIndex = 2;
            cboPage.SelectedIndexChanged += cboPage_SelectedIndexChanged;
            // 
            // lblPageSize
            // 
            lblPageSize.AutoSize = true;
            lblPageSize.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageSize.Location = new Point(483, 5);
            lblPageSize.Name = "lblPageSize";
            lblPageSize.Size = new Size(63, 18);
            lblPageSize.TabIndex = 1;
            lblPageSize.Text = "Số trang";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPage.Location = new Point(334, 5);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(47, 18);
            lblPage.TabIndex = 0;
            lblPage.Text = "Trang";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslLabel, tsslName, tsslLogOut, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 621);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(622, 26);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslLabel
            // 
            tsslLabel.Name = "tsslLabel";
            tsslLabel.Size = new Size(78, 20);
            tsslLabel.Text = "Welcome,";
            // 
            // tsslName
            // 
            tsslName.ForeColor = Color.SeaGreen;
            tsslName.Name = "tsslName";
            tsslName.Size = new Size(44, 20);
            // 
            // tsslLogOut
            // 
            tsslLogOut.IsLink = true;
            tsslLogOut.Name = "tsslLogOut";
            tsslLogOut.Size = new Size(77, 20);
            tsslLogOut.Text = "Đăng xuất";
            tsslLogOut.Click += tsslLogOut_Click;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 18);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 648);
            Controls.Add(tlpMain);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hôm nay ăn gì?";
            Load += MainForm_Load;
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tlpContent.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            pnlAllList.ResumeLayout(false);
            pnlAllList.PerformLayout();
            pnlMyList.ResumeLayout(false);
            pnlMyList.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblBanner;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnRandom;
        private TableLayoutPanel tlpContent;
        private TabControl tabMain;
        private TabPage tbAll;
        private TabPage tbMine;
        private Panel pnlAllList;
        private Panel pnlMyList;
        private FlowLayoutPanel flpAllFoods;
        private FlowLayoutPanel flpMyFoods;
        private Panel pnlFooter;
        private Label lblPage;
        private Label lblPageSize;
        private ComboBox cboPageSize;
        private ComboBox cboPage;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslLabel;
        private ToolStripStatusLabel tsslLogOut;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel tsslName;
    }
}