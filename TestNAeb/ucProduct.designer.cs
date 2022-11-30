
namespace TestNAeb
{
    partial class ucProduct
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
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtMaker = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctImage
            // 
            this.pctImage.Location = new System.Drawing.Point(3, 3);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(113, 114);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtMaker);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(122, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 114);
            this.panel1.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPrice.Location = new System.Drawing.Point(2, 84);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(53, 20);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Text = "label4";
            // 
            // txtMaker
            // 
            this.txtMaker.AutoSize = true;
            this.txtMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMaker.Location = new System.Drawing.Point(3, 58);
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(53, 20);
            this.txtMaker.TabIndex = 4;
            this.txtMaker.Text = "label3";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDescription.Location = new System.Drawing.Point(3, 31);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(53, 20);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "label2";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(57, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "label1";
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCount.Location = new System.Drawing.Point(16, 45);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(53, 20);
            this.txtCount.TabIndex = 6;
            this.txtCount.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCount);
            this.panel2.Location = new System.Drawing.Point(601, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 114);
            this.panel2.TabIndex = 7;
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctImage);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(700, 120);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtMaker;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label txtCount;
        private System.Windows.Forms.Panel panel2;
    }
}
