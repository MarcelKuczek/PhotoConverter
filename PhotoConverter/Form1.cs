using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoConverter
{
    public partial class Form1 : Form
    {
        // import cpp dll
        [DllImport("ImageProcessingCppDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ConvertToGrayscaleCpp(IntPtr imageData, int width, int height, int stride);
        // import asm dll
        [DllImport("ImageProcessingAsmDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ConvertToGrayscaleAsm(IntPtr imageData, int width, int height, int stride);

        public Form1()
        {
            InitializeComponent();
            numericThreads.Minimum = 1;
            numericThreads.Maximum = Environment.ProcessorCount;
        }

        //Load image 
        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                //checks successfully selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxBefore.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxBefore.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void ConvertToGrayscale(Bitmap bitmap, bool useCpp)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            //Number of bytes in a single row
            int stride;

            //Locks the Bitmap, enabling manipulate pixel data
            //Start 0,0 end width, height of the photo
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                                                    ImageLockMode.ReadWrite,
                                                    PixelFormat.Format32bppArgb);
            stride = bitmapData.Stride;

            int numThreads = (int)numericThreads.Value;
            //Number of rows (height) each thread will process
            int chunkHeight = height / numThreads;

            Task[] tasks = new Task[numThreads];

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < numThreads; i++)
            {
                //Starting row index for the thread’s chunk
                int yStart = i * chunkHeight;
                int yEnd = (i == numThreads - 1) ? height : yStart + chunkHeight;

                tasks[i] = Task.Run(() =>
                {
                    IntPtr rowStartPtr = IntPtr.Add(bitmapData.Scan0, yStart * stride);
                    int rowsToProcess = yEnd - yStart;

                    if (useCpp)
                    {
                        ConvertToGrayscaleCpp(rowStartPtr, width, rowsToProcess, stride);
                    }
                    else
                    {
                        ConvertToGrayscaleAsm(rowStartPtr, width, rowsToProcess, stride);
                    }
                });
            }

            Task.WaitAll(tasks);
            bitmap.UnlockBits(bitmapData);
            stopwatch.Stop();

            String method = useCpp ? "C++" : "ASM";
            labelTime.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms ({method})";
            pictureBoxAfter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAfter.Image = bitmap;
        }

        private void buttonConvertToGrayscaleCpp_Click(object sender, EventArgs e)
        {
            if (pictureBoxBefore.Image == null)
            {
                MessageBox.Show("Please, load a picture!");
                return;
            }
            Bitmap bitmap = new Bitmap(pictureBoxBefore.Image);
            ConvertToGrayscale(bitmap, useCpp: true);
        }

        private void buttonConvertToGrayscaleAsm_Click(object sender, EventArgs e)
        {
            if (pictureBoxBefore.Image == null)
            {
                MessageBox.Show("Please, load a picture!");
                return;
            }
            Bitmap bitmap = new Bitmap(pictureBoxBefore.Image);
            ConvertToGrayscale(bitmap, useCpp: false);
        }
    }
}
