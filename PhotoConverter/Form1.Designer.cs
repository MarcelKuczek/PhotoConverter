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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.pictureBoxBefore = new System.Windows.Forms.PictureBox();
            this.pictureBoxAfter = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericThreads = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoadImage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLoadImage.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadImage.Image")));
            this.buttonLoadImage.Location = new System.Drawing.Point(625, 404);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(196, 62);
            this.buttonLoadImage.TabIndex = 0;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConvert.BackgroundImage")));
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConvert.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonConvert.Image = ((System.Drawing.Image)(resources.GetObject("buttonConvert.Image")));
            this.buttonConvert.Location = new System.Drawing.Point(625, 486);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(196, 62);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert by C++ ";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvertToGrayscaleCpp_Click);
            // 
            // pictureBoxBefore
            // 
            this.pictureBoxBefore.BackgroundImage = global::PhotoConverter.Properties.Resources.concrete_wall;
            this.pictureBoxBefore.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBefore.Name = "pictureBoxBefore";
            this.pictureBoxBefore.Size = new System.Drawing.Size(594, 624);
            this.pictureBoxBefore.TabIndex = 3;
            this.pictureBoxBefore.TabStop = false;
            // 
            // pictureBoxAfter
            // 
            this.pictureBoxAfter.BackgroundImage = global::PhotoConverter.Properties.Resources.concrete_wall1;
            this.pictureBoxAfter.Location = new System.Drawing.Point(848, 12);
            this.pictureBoxAfter.Name = "pictureBoxAfter";
            this.pictureBoxAfter.Size = new System.Drawing.Size(594, 631);
            this.pictureBoxAfter.TabIndex = 4;
            this.pictureBoxAfter.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTime.Image = global::PhotoConverter.Properties.Resources.dark_wall;
            this.labelTime.Location = new System.Drawing.Point(633, 67);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(93, 39);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "0 ms";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(625, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convert by Assembler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConvertToGrayscaleAsm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Image = global::PhotoConverter.Properties.Resources.dark_wall;
            this.label1.Location = new System.Drawing.Point(630, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time:";
            // 
            // numericThreads
            // 
            this.numericThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericThreads.Location = new System.Drawing.Point(669, 347);
            this.numericThreads.Name = "numericThreads";
            this.numericThreads.Size = new System.Drawing.Size(120, 40);
            this.numericThreads.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Image = global::PhotoConverter.Properties.Resources.dark_wall;
            this.label2.Location = new System.Drawing.Point(620, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of threads:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::PhotoConverter.Properties.Resources.dark_wall;
            this.ClientSize = new System.Drawing.Size(1454, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericThreads);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxAfter);
            this.Controls.Add(this.pictureBoxBefore);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonLoadImage);
            this.Name = "Form1";
            this.Text = "Photo Colored to Black and White Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.PictureBox pictureBoxBefore;
        private System.Windows.Forms.PictureBox pictureBoxAfter;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericThreads;
        private System.Windows.Forms.Label label2;
    }
}

