namespace PhotoConverter
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.pictureBoxBefore = new System.Windows.Forms.PictureBox();
            this.pictureBoxAfter = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(323, 304);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(157, 34);
            this.buttonLoadImage.TabIndex = 0;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(338, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(323, 344);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(157, 33);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBefore
            // 
            this.pictureBoxBefore.Location = new System.Drawing.Point(12, 19);
            this.pictureBoxBefore.Name = "pictureBoxBefore";
            this.pictureBoxBefore.Size = new System.Drawing.Size(326, 253);
            this.pictureBoxBefore.TabIndex = 3;
            this.pictureBoxBefore.TabStop = false;
            // 
            // pictureBoxAfter
            // 
            this.pictureBoxAfter.Location = new System.Drawing.Point(462, 19);
            this.pictureBoxAfter.Name = "pictureBoxAfter";
            this.pictureBoxAfter.Size = new System.Drawing.Size(326, 253);
            this.pictureBoxAfter.TabIndex = 4;
            this.pictureBoxAfter.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(383, 192);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(26, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxAfter);
            this.Controls.Add(this.pictureBoxBefore);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonLoadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.PictureBox pictureBoxBefore;
        private System.Windows.Forms.PictureBox pictureBoxAfter;
        private System.Windows.Forms.Label labelTime;
    }
}

