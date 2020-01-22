using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FilterWindow : Form
    {
        public Bitmap DefaultImage { get; set; }


        public FilterWindow(Bitmap WorkingOnImage)
        {
            InitializeComponent();
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            DefaultImage = WorkingOnImage;
            pictureBox1.Image = WorkingOnImage;
          
        }

        private void Grayscale_click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageFilter.DrawAsGrayscale(DefaultImage);
        }

        private void Sepia_click(object sender, EventArgs e)
        {

            pictureBox1.Image = ImageFilter.DrawAsSepiaTone(DefaultImage);

        }

        private void Negative_click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageFilter.DrawAsNegative(DefaultImage);

        }
    }
}
