namespace Bai02
{
    partial class Bai2
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
            txtFilePath = new TextBox();
            btnDownload = new Button();
            rtbContent = new RichTextBox();
            URL = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 27);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(627, 27);
            txtURL.TabIndex = 0;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 80);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(627, 27);
            txtFilePath.TabIndex = 1;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(675, 25);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(113, 52);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(12, 113);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(776, 325);
            rtbContent.TabIndex = 4;
            rtbContent.Text = "";
            // 
            // URL
            // 
            URL.AutoSize = true;
            URL.Location = new Point(12, 4);
            URL.Name = "URL";
            URL.Size = new Size(35, 20);
            URL.TabIndex = 5;
            URL.Text = "URL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "FIle Path";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(URL);
            Controls.Add(rtbContent);
            Controls.Add(btnDownload);
            Controls.Add(txtFilePath);
            Controls.Add(txtURL);
            Name = "Bai2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private TextBox txtFilePath;
        private Button btnDownload;
        private RichTextBox rtbContent;
        private Label URL;
        private Label label1;
    }
}
