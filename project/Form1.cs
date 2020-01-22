using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace project
{
    public partial class Form1 : Form
    {
        private Bitmap chosenImage { get; set; }
        private Bitmap workingImage { get; set; }

        

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            workingImage = ImageFilter.adjustBrightness(chosenImage,trackBar1.Value);
            pictureBox2.Image = workingImage;
        }

        private void trackBar2_Scroll(object sender, EventArgs e) {

            workingImage = ImageFilter.adjustContrast(chosenImage, trackBar2.Value);
            pictureBox2.Image = workingImage;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"; //hiuhiuh
            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                chosenImage = new Bitmap(opnfd.FileName);
                workingImage = chosenImage;
                pictureBox1.Image = chosenImage;
                pictureBox2.Image = workingImage;
            }

        }

        private void rotate_Click(object sender, EventArgs e) {

            chosenImage = new Bitmap( ImageFilter.RotateImage90CW(chosenImage));
            pictureBox2.Image = chosenImage;
           
        }

        private void button2_Clik(object sender, EventArgs e)
        {
            
            workingImage = new Bitmap(ImageFilter.FilteredImage(workingImage));
            pictureBox2.Image = workingImage;

        }

       
    }
}
