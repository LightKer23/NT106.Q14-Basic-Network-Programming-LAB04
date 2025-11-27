namespace Bai04.Forms
{
    partial class movieBanner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            movieName = new Label();
            url = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // movieName
            // 
            movieName.AutoSize = true;
            movieName.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieName.Location = new Point(126, 0);
            movieName.Name = "movieName";
            movieName.Size = new Size(83, 36);
            movieName.TabIndex = 1;
            movieName.Text = "label1";
            // 
            // url
            // 
            url.AutoSize = true;
            url.Location = new Point(126, 46);
            url.Name = "url";
            url.Size = new Size(50, 20);
            url.TabIndex = 2;
            url.Text = "label1";
            // 
            // movieBanner
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(url);
            Controls.Add(movieName);
            Controls.Add(pictureBox1);
            Name = "movieBanner";
            Size = new Size(700, 100);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label movieName;
        private Label url;
    }
}
