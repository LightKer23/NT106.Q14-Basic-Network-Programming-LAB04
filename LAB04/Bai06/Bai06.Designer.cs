namespace Bai06
{
    partial class Bai06
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
            txtURL = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnLay = new Button();
            label2 = new Label();
            txtToken = new TextBox();
            rtbShow = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(119, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(348, 27);
            txtURL.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Đường dẫn:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtToken);
            groupBox1.Location = new Point(26, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 78);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Token";
            // 
            // btnLay
            // 
            btnLay.Location = new Point(366, 26);
            btnLay.Name = "btnLay";
            btnLay.Size = new Size(69, 29);
            btnLay.TabIndex = 3;
            btnLay.Text = "LẤY";
            btnLay.UseVisualStyleBackColor = true;
            btnLay.Click += btnLay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 29);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Token";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(93, 26);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(267, 27);
            txtToken.TabIndex = 0;
            // 
            // rtbShow
            // 
            rtbShow.Location = new Point(26, 140);
            rtbShow.Name = "rtbShow";
            rtbShow.ReadOnly = true;
            rtbShow.Size = new Size(441, 161);
            rtbShow.TabIndex = 3;
            rtbShow.Text = "";
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 313);
            Controls.Add(rtbShow);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtURL);
            Name = "Bai06";
            Text = "Bài 6";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtToken;
        private RichTextBox rtbShow;
        private Button btnLay;
    }
}
