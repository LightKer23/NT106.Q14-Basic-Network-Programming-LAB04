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
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 47);
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
            btnDownload.Location = new Point(694, 47);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(94, 29);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(12, 113);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(776, 325);
            rtbContent.TabIndex = 4;
            rtbContent.Text = "";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
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
    }
}
