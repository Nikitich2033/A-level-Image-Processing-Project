using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace project
{
    public partial class ImageComparisonWindow : Form
    {
        public ImageComparisonWindow()
        {
            InitializeComponent();
        }

        private void UploadImgBox1(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;*.bmp)|*.jpg;*.jpeg;.*.gif;*.png;*.bmp";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(opnfd.FileName);

            }
        }

        private void UploadImgBox2(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;*.bmp)|*.jpg;*.jpeg;.*.gif;*.png;*.bmp";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                pictureBox2.Image = new Bitmap(opnfd.FileName);

            }
        }

        private async void SortingByFolders(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog();

            folderDialog.InitialDirectory = "c:\\Users";
            folderDialog.IsFolderPicker = true;

            if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox5.Text = folderDialog.FileName;

                string[] arrayOfImagePaths = Directory.GetFiles(folderDialog.FileName);

                foreach (var Filepath in arrayOfImagePaths)
                {

                    pictureBox2.Image = new Bitmap(Filepath);
                    textBox1.Text = ImageManipulation.CompareImages(new Bitmap(pictureBox1.Image), 
                        new Bitmap(pictureBox2.Image)).ToString();

                    await Task.Delay(1000);


                }
            }
        }

        private void Compare(object sender, EventArgs e)
        {
            Bitmap BM1 = new Bitmap(pictureBox1.Image);
            Bitmap BM2 = new Bitmap(pictureBox2.Image);

            textBox1.Text = ImageManipulation.CompareImages(BM1, BM2).ToString();
        }

        private void LaplacianCompare(object sender, EventArgs e)
        {
            //could outline the white outline using a pen tool and replace a bitmap with that sketch
            bool grayscale = true;
            Bitmap BM1 = ImageFilter.Laplacian3x3Filter(new Bitmap(pictureBox1.Image), grayscale);
            Bitmap BM2 = ImageFilter.Laplacian3x3Filter(new Bitmap(pictureBox2.Image), grayscale);

            ImageFilter.ReplaceColor(BM1, Color.FromArgb(0, 0, 0), Color.Empty);
            ImageFilter.ReplaceColor(BM1, Color.FromArgb(0, 0, 0), Color.Empty);

            pictureBox1.Image = BM1;
            pictureBox2.Image = BM2;

            textBox1.Text = ImageManipulation.CompareImages(BM1, BM2).ToString();
        }
    }
}
