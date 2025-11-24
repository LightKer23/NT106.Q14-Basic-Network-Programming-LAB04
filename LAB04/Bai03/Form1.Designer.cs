namespace Bai03
{
    partial class Form1
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
            btnLoad = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnReload = new Button();
            txtUrl = new TextBox();
            btnDowFi = new Button();
            btnDowRe = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(796, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(145, 30);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 89);
            webView21.Name = "webView21";
            webView21.Size = new Size(951, 523);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(12, 12);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(145, 30);
            btnReload.TabIndex = 1;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(176, 12);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(600, 27);
            txtUrl.TabIndex = 2;
            // 
            // btnDowFi
            // 
            btnDowFi.Location = new Point(631, 47);
            btnDowFi.Name = "btnDowFi";
            btnDowFi.Size = new Size(145, 30);
            btnDowFi.TabIndex = 3;
            btnDowFi.Text = "Down Files HTML";
            btnDowFi.UseVisualStyleBackColor = true;
            btnDowFi.Click += btnDowFi_Click;
            // 
            // btnDowRe
            // 
            btnDowRe.Location = new Point(796, 47);
            btnDowRe.Name = "btnDowRe";
            btnDowRe.Size = new Size(145, 30);
            btnDowRe.TabIndex = 4;
            btnDowRe.Text = "Down Resources";
            btnDowRe.UseVisualStyleBackColor = true;
            btnDowRe.Click += btnDowRe_Click;
            // 
            // Web_Browser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 612);
            Controls.Add(btnDowRe);
            Controls.Add(btnDowFi);
            Controls.Add(txtUrl);
            Controls.Add(btnReload);
            Controls.Add(btnLoad);
            Controls.Add(webView21);
            Name = "Web_Browser";
            Text = "Web_Browser";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btnLoad;
        private Button btnReload;
        private TextBox txtUrl;
        private Button btnDowFi;
        private Button btnDowRe;
    }
}
