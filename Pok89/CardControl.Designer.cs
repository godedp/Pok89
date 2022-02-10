namespace Pok89
{
    partial class CardControl
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
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.Image2 = new System.Windows.Forms.PictureBox();
            this.Image3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image3)).BeginInit();
            this.SuspendLayout();
            // 
            // Image1
            // 
            this.Image1.Location = new System.Drawing.Point(3, 3);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(60, 84);
            this.Image1.TabIndex = 1;
            this.Image1.TabStop = false;
            // 
            // Image2
            // 
            this.Image2.Location = new System.Drawing.Point(69, 3);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(60, 84);
            this.Image2.TabIndex = 2;
            this.Image2.TabStop = false;
            // 
            // Image3
            // 
            this.Image3.Location = new System.Drawing.Point(135, 3);
            this.Image3.Name = "Image3";
            this.Image3.Size = new System.Drawing.Size(60, 84);
            this.Image3.TabIndex = 3;
            this.Image3.TabStop = false;
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Image3);
            this.Controls.Add(this.Image2);
            this.Controls.Add(this.Image1);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(200, 91);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.PictureBox Image2;
        private System.Windows.Forms.PictureBox Image3;
    }
}
