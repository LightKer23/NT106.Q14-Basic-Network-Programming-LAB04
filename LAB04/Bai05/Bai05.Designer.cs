namespace Bai05
{
    partial class Bai05
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
            label1 = new Label();
            txtURL = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            rtbShow = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Đường dẫn:";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(117, 16);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(365, 27);
            txtURL.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Location = new Point(24, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 116);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 73);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên đăng nhập:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(328, 30);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 67);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(122, 70);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(200, 27);
            txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(122, 30);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(200, 27);
            txtUser.TabIndex = 0;
            // 
            // rtbShow
            // 
            rtbShow.Location = new Point(24, 183);
            rtbShow.Name = "rtbShow";
            rtbShow.ReadOnly = true;
            rtbShow.Size = new Size(458, 145);
            rtbShow.TabIndex = 3;
            rtbShow.Text = "";
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 340);
            Controls.Add(rtbShow);
            Controls.Add(groupBox1);
            Controls.Add(txtURL);
            Controls.Add(label1);
            Name = "Bai05";
            Text = "Bai05";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtURL;
        private GroupBox groupBox1;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label3;
        private Label label2;
        private RichTextBox rtbShow;
    }
}