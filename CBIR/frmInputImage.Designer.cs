namespace CBIR
{
    partial class frmInputImage
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
            this.btnBrowes = new System.Windows.Forms.Button();
            this.pbINewImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbINewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowes
            // 
            this.btnBrowes.Location = new System.Drawing.Point(108, 290);
            this.btnBrowes.Name = "btnBrowes";
            this.btnBrowes.Size = new System.Drawing.Size(101, 23);
            this.btnBrowes.TabIndex = 0;
            this.btnBrowes.Text = "Browes Image";
            this.btnBrowes.UseVisualStyleBackColor = true;
            this.btnBrowes.Click += new System.EventHandler(this.btnBrowes_Click);
            // 
            // pbINewImage
            // 
            this.pbINewImage.Location = new System.Drawing.Point(108, 58);
            this.pbINewImage.Name = "pbINewImage";
            this.pbINewImage.Size = new System.Drawing.Size(182, 209);
            this.pbINewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbINewImage.TabIndex = 1;
            this.pbINewImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(215, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmInputImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 472);
            this.Controls.Add(this.pbINewImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowes);
            this.Name = "frmInputImage";
            this.Text = "Insert Image";
            ((System.ComponentModel.ISupportInitialize)(this.pbINewImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowes;
        private System.Windows.Forms.PictureBox pbINewImage;
        private System.Windows.Forms.Button btnSave;
    }
}

