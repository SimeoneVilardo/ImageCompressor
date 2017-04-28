namespace ImageCompressorUI
{
    partial class ImageCompressorUI
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.gbxImages = new System.Windows.Forms.GroupBox();
            this.gbxCompress = new System.Windows.Forms.GroupBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.NumericUpDown();
            this.btnCompress = new System.Windows.Forms.Button();
            this.gbxImages.SuspendLayout();
            this.gbxCompress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(100, 23);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(414, 20);
            this.txtPath.TabIndex = 0;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(16, 26);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(78, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "File o directory:";
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsePath.Location = new System.Drawing.Point(520, 21);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePath.TabIndex = 2;
            this.btnBrowsePath.Text = "...";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.btnBrowsePath_Click);
            // 
            // gbxImages
            // 
            this.gbxImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxImages.Controls.Add(this.lblPath);
            this.gbxImages.Controls.Add(this.btnBrowsePath);
            this.gbxImages.Controls.Add(this.txtPath);
            this.gbxImages.Location = new System.Drawing.Point(12, 12);
            this.gbxImages.Name = "gbxImages";
            this.gbxImages.Size = new System.Drawing.Size(612, 58);
            this.gbxImages.TabIndex = 3;
            this.gbxImages.TabStop = false;
            this.gbxImages.Text = "Seleziona le immagini:";
            // 
            // gbxCompress
            // 
            this.gbxCompress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCompress.Controls.Add(this.btnCompress);
            this.gbxCompress.Controls.Add(this.txtQuality);
            this.gbxCompress.Controls.Add(this.lblQuality);
            this.gbxCompress.Location = new System.Drawing.Point(13, 76);
            this.gbxCompress.Name = "gbxCompress";
            this.gbxCompress.Size = new System.Drawing.Size(611, 59);
            this.gbxCompress.TabIndex = 4;
            this.gbxCompress.TabStop = false;
            this.gbxCompress.Text = "Comprimi le immagini:";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(50, 30);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(43, 13);
            this.lblQuality.TabIndex = 0;
            this.lblQuality.Text = "Qualità:";
            // 
            // txtQuality
            // 
            this.txtQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuality.Location = new System.Drawing.Point(99, 28);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(121, 20);
            this.txtQuality.TabIndex = 5;
            // 
            // btnCompress
            // 
            this.btnCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompress.Location = new System.Drawing.Point(226, 25);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(75, 23);
            this.btnCompress.TabIndex = 6;
            this.btnCompress.Text = "Comprimi";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // ImageCompressorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 151);
            this.Controls.Add(this.gbxCompress);
            this.Controls.Add(this.gbxImages);
            this.MinimumSize = new System.Drawing.Size(330, 190);
            this.Name = "ImageCompressorUI";
            this.Text = "ImageCompressor";
            this.gbxImages.ResumeLayout(false);
            this.gbxImages.PerformLayout();
            this.gbxCompress.ResumeLayout(false);
            this.gbxCompress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowsePath;
        private System.Windows.Forms.GroupBox gbxImages;
        private System.Windows.Forms.GroupBox gbxCompress;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.NumericUpDown txtQuality;
        private System.Windows.Forms.Button btnCompress;
    }
}

