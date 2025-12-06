namespace Bai01
{
    partial class Bai1
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
            btnGet = new Button();
            rtbContent = new RichTextBox();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(27, 23);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(620, 27);
            txtURL.TabIndex = 0;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(668, 23);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(105, 29);
            btnGet.TabIndex = 1;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(27, 72);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(746, 376);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbContent);
            Controls.Add(btnGet);
            Controls.Add(txtURL);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private Button btnGet;
        private RichTextBox rtbContent;
    }
}
