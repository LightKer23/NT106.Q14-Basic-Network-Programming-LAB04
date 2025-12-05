namespace Bai07
{
    partial class FoodItemControl
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
            pbImage = new PictureBox();
            pnlText = new Panel();
            lblAddress = new Label();
            lblContributor = new Label();
            lblPrice = new Label();
            lbl03 = new Label();
            lbl02 = new Label();
            lbl01 = new Label();
            lblNameFood = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            pnlText.SuspendLayout();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Location = new Point(0, 0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(120, 152);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // pnlText
            // 
            pnlText.Controls.Add(lblAddress);
            pnlText.Controls.Add(lblContributor);
            pnlText.Controls.Add(lblPrice);
            pnlText.Controls.Add(lbl03);
            pnlText.Controls.Add(lbl02);
            pnlText.Controls.Add(lbl01);
            pnlText.Controls.Add(lblNameFood);
            pnlText.Dock = DockStyle.Right;
            pnlText.Location = new Point(121, 0);
            pnlText.Name = "pnlText";
            pnlText.Size = new Size(479, 155);
            pnlText.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(124, 80);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(0, 20);
            lblAddress.TabIndex = 6;
            // 
            // lblContributor
            // 
            lblContributor.AutoSize = true;
            lblContributor.ForeColor = Color.Green;
            lblContributor.Location = new Point(124, 115);
            lblContributor.Name = "lblContributor";
            lblContributor.Size = new Size(0, 20);
            lblContributor.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(124, 45);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 4;
            // 
            // lbl03
            // 
            lbl03.Location = new Point(8, 126);
            lbl03.Name = "lbl03";
            lbl03.Size = new Size(81, 25);
            lbl03.TabIndex = 3;
            lbl03.Text = "Đóng góp:";
            // 
            // lbl02
            // 
            lbl02.Location = new Point(8, 91);
            lbl02.Name = "lbl02";
            lbl02.Size = new Size(63, 25);
            lbl02.TabIndex = 2;
            lbl02.Text = "Địa chỉ:";
            // 
            // lbl01
            // 
            lbl01.Location = new Point(8, 56);
            lbl01.Name = "lbl01";
            lbl01.Size = new Size(43, 25);
            lbl01.TabIndex = 1;
            lbl01.Text = "Giá:";
            // 
            // lblNameFood
            // 
            lblNameFood.AutoSize = true;
            lblNameFood.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameFood.ForeColor = Color.FromArgb(255, 128, 0);
            lblNameFood.Location = new Point(8, 10);
            lblNameFood.Name = "lblNameFood";
            lblNameFood.Size = new Size(149, 28);
            lblNameFood.TabIndex = 0;
            lblNameFood.Text = "Tên món ăn";
            // 
            // FoodItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlText);
            Controls.Add(pbImage);
            Name = "FoodItemControl";
            Size = new Size(600, 155);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            pnlText.ResumeLayout(false);
            pnlText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImage;
        private Panel pnlText;
        private Label lbl03;
        private Label lbl02;
        private Label lbl01;
        private Label lblNameFood;
        private Label lblAddress;
        private Label lblContributor;
        private Label lblPrice;
    }
}
