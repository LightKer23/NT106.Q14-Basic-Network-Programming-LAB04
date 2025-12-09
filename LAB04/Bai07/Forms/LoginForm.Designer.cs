namespace Bai07
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblBanner = new Label();
            lblUsername = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            panel2 = new Panel();
            txtPsswrd = new TextBox();
            btnCancel = new Button();
            btnLogin = new Button();
            btnRegister = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblBanner);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 80);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(269, 39);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 3;
            label2.Text = "Phiên bản số 4";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eat_2411129_640;
            pictureBox1.Location = new Point(61, 3);
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
            lblBanner.Location = new Point(160, 4);
            lblBanner.Name = "lblBanner";
            lblBanner.Size = new Size(261, 46);
            lblBanner.TabIndex = 1;
            lblBanner.Text = "HÔM NAY ĂN GÌ?";
            lblBanner.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(15, 17);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(131, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên người dùng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 52);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 2;
            label1.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(155, 17);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(257, 27);
            txtUsername.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(txtPsswrd);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lblUsername);
            panel2.Location = new Point(1, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 142);
            panel2.TabIndex = 5;
            // 
            // txtPsswrd
            // 
            txtPsswrd.Location = new Point(155, 52);
            txtPsswrd.Name = "txtPsswrd";
            txtPsswrd.Size = new Size(257, 27);
            txtPsswrd.TabIndex = 2;
            txtPsswrd.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 10.2F);
            btnCancel.Location = new Point(280, 92);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Tahoma", 10.2F);
            btnLogin.Location = new Point(155, 92);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Ok";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Tahoma", 10.2F);
            btnRegister.Location = new Point(405, 92);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 35);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Đăng ký...";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 223);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblBanner;
        private Label lblUsername;
        private Label label1;
        private TextBox txtUsername;
        private Panel panel2;
        private Button btnCancel;
        private Button btnLogin;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtPsswrd;
    }
}
