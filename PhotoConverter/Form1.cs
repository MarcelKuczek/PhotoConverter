using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Załaduj wybrany obraz do kontrolki PictureBox
                    pictureBoxBefore.Image = new Bitmap(ofd.FileName);
                }
            }
        }
    }
}
