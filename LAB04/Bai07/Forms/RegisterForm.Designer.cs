namespace Bai07
{
    partial class RegisterForm
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
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblBanner = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            btnRegister = new Button();
            btnLogin = new Button();
            comboBox1 = new ComboBox();
            rdBtnFemale = new RadioButton();
            rdBtnMale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            txtPsswrd = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblPsswrd = new Label();
            lblLanguage = new Label();
            lblSex = new Label();
            lblBirthday = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
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
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 75);
            panel1.TabIndex = 1;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(rdBtnFemale);
            panel2.Controls.Add(rdBtnMale);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtPsswrd);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(lblPsswrd);
            panel2.Controls.Add(lblLanguage);
            panel2.Controls.Add(lblSex);
            panel2.Controls.Add(lblBirthday);
            panel2.Controls.Add(lblFirstName);
            panel2.Controls.Add(lblLastName);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblPhone);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(1, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 380);
            panel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 10.2F);
            btnCancel.Location = new Point(280, 337);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Tahoma", 10.2F);
            btnRegister.Location = new Point(155, 337);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 35);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Ok";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Tahoma", 10.2F);
            btnLogin.Location = new Point(405, 337);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 35);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "Đăng nhập...";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnRegister_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "vi", "en" });
            comboBox1.Location = new Point(155, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 28);
            comboBox1.TabIndex = 21;
            // 
            // rdBtnFemale
            // 
            rdBtnFemale.AutoSize = true;
            rdBtnFemale.Location = new Point(269, 227);
            rdBtnFemale.Name = "rdBtnFemale";
            rdBtnFemale.Size = new Size(50, 24);
            rdBtnFemale.TabIndex = 20;
            rdBtnFemale.TabStop = true;
            rdBtnFemale.Text = "Nữ";
            rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdBtnMale
            // 
            rdBtnMale.AutoSize = true;
            rdBtnMale.Location = new Point(155, 227);
            rdBtnMale.Name = "rdBtnMale";
            rdBtnMale.Size = new Size(62, 24);
            rdBtnMale.TabIndex = 19;
            rdBtnMale.TabStop = true;
            rdBtnMale.Text = "Nam";
            rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(155, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // txtPsswrd
            // 
            txtPsswrd.Location = new Point(155, 297);
            txtPsswrd.Name = "txtPsswrd";
            txtPsswrd.Size = new Size(257, 27);
            txtPsswrd.TabIndex = 17;
            txtPsswrd.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(155, 157);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(257, 27);
            txtPhone.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(155, 87);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(257, 27);
            txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(155, 52);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(257, 27);
            txtFirstName.TabIndex = 13;
            // 
            // lblPsswrd
            // 
            lblPsswrd.AutoSize = true;
            lblPsswrd.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPsswrd.Location = new Point(15, 297);
            lblPsswrd.Name = "lblPsswrd";
            lblPsswrd.Size = new Size(84, 21);
            lblPsswrd.TabIndex = 12;
            lblPsswrd.Text = "Mật khẩu:";
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLanguage.Location = new Point(15, 262);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(87, 21);
            lblLanguage.TabIndex = 11;
            lblLanguage.Text = "Ngôn ngữ:";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(15, 227);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(77, 21);
            lblSex.TabIndex = 10;
            lblSex.Text = "Giới tính:";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthday.Location = new Point(15, 192);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(88, 21);
            lblBirthday.TabIndex = 9;
            lblBirthday.Text = "Ngày sinh:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(15, 52);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(36, 21);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "Họ:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(15, 87);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(44, 21);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Tên:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(15, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(15, 157);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(113, 21);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(15, 17);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(131, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Tên người dùng:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(155, 17);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(257, 27);
            txtUsername.TabIndex = 3;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 456);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegisterForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblBanner;
        private Panel panel2;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblBirthday;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblSex;
        private Label lblPsswrd;
        private Label lblLanguage;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtPsswrd;
        private RadioButton rdBtnFemale;
        private RadioButton rdBtnMale;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button btnCancel;
        private Button btnRegister;
        private Button btnLogin;
    }
}