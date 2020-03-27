using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Microsoft.ML;
using System.Diagnostics;

namespace project
{
    public partial class MainWindow : Form
    {
       
        private UserImage UploadedImageBitmap { get; set; }

        public FilterInfoCollection videoDevices { get; set; }

        public VideoCaptureDevice videoSource { get; set; }
        
        public List<UserImage> userImages { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            pictureBox1.BorderStyle = BorderStyle.Fixed3D;

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            UploadedImageBitmap = new UserImage();           
            userImages = UploadedImageBitmap.check_JSON();

            

        }


        private void UploadImage(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;*.bmp)|*.jpg;*.jpeg;.*.gif;*.png;*.bmp";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                UploadedImageBitmap.BM = new Bitmap(opnfd.FileName);
                UploadedImageBitmap.startBM = UploadedImageBitmap.BM;
                pictureBox1.Image = UploadedImageBitmap.BM;
                UploadedImageBitmap.filepath = Path.GetFullPath(opnfd.FileName);
            }

            //get the values for trackbars from JSON
            int index = 0;
            foreach (var image in userImages)
            {
                if (image.filepath == opnfd.FileName)
                {
                    trackBar1.Value = image.brightness;
                    trackBar2.Value = image.contrast;
                    trackBar3.Value = image.saturation;
                    
                    
                    UpdateTrackBarTextboxes(image);
                    UpdateUserImageObject(image,UploadedImageBitmap);
                    index = userImages.IndexOf(image);
                    
                }
               
            }

        
        }

        private void SaveImage(object sender, EventArgs e)
        {
            SaveFileDialog savefiledg = new SaveFileDialog();
            savefiledg.Filter = "Image Files| *.png;*.bmp;*.jpg;*.gif;";
            ImageFormat format = ImageFormat.Png;

            if (savefiledg.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(savefiledg.FileName);

                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;

                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;

                    case ".gif":
                        format = ImageFormat.Gif;
                        break;

                }

                pictureBox1.Image.Save(savefiledg.FileName, format);
                UploadedImageBitmap.filepath = savefiledg.FileName;
                userImages = UploadedImageBitmap.check_JSON();
                userImages.Add(UploadedImageBitmap);
                UploadedImageBitmap.update_JSON(userImages);
                
            }
            

        }


        private void BrightnessAdjustment(object sender, EventArgs e) {
            

            UploadedImageBitmap.BM = ImageFilter.AdjustBrightness(UploadedImageBitmap.startBM, trackBar1.Value);
            UploadedImageBitmap.BM = ImageFilter.AdjustContrast(UploadedImageBitmap.BM,UploadedImageBitmap.contrast);
            UploadedImageBitmap.BM = ImageFilter.AdjustSaturation(UploadedImageBitmap.BM, UploadedImageBitmap.saturation);

            pictureBox1.Image = UploadedImageBitmap.BM;

            UploadedImageBitmap.brightness = trackBar1.Value;
            UpdateTrackBarTextboxes(UploadedImageBitmap);
            
            
        }

        private void ContrastAdjustment(object sender, EventArgs e) {
            UploadedImageBitmap.BM = ImageFilter.AdjustContrast(UploadedImageBitmap.startBM, trackBar2.Value);
            UploadedImageBitmap.BM = ImageFilter.AdjustBrightness(UploadedImageBitmap.BM, UploadedImageBitmap.brightness);
            UploadedImageBitmap.BM = ImageFilter.AdjustSaturation(UploadedImageBitmap.BM, UploadedImageBitmap.saturation);

            pictureBox1.Image = UploadedImageBitmap.BM;


            UploadedImageBitmap.contrast = trackBar2.Value;
            UpdateTrackBarTextboxes(UploadedImageBitmap);
           

        }
     

        private void SaturationAdjustment(object sender, EventArgs e)
        {
            UploadedImageBitmap.BM = ImageFilter.AdjustSaturation(UploadedImageBitmap.startBM, trackBar3.Value);

            UploadedImageBitmap.BM = ImageFilter.AdjustBrightness(UploadedImageBitmap.BM, UploadedImageBitmap.brightness);
            UploadedImageBitmap.BM = ImageFilter.AdjustContrast(UploadedImageBitmap.BM, UploadedImageBitmap.contrast);

            pictureBox1.Image = UploadedImageBitmap.BM;

            UploadedImageBitmap.saturation = trackBar3.Value;
            UpdateTrackBarTextboxes(UploadedImageBitmap);
            

        }

        

        private void Grayscale_click(object sender, EventArgs e)
        {
            UploadedImageBitmap.BM = ImageFilter.DrawAsGrayscale(UploadedImageBitmap.BM);
            pictureBox1.Image = UploadedImageBitmap.BM;
        }

        private void Sepia_click(object sender, EventArgs e)
        {
            
            UploadedImageBitmap.BM = ImageFilter.DrawAsSepiaTone(UploadedImageBitmap.BM);
            pictureBox1.Image = UploadedImageBitmap.BM;
        }

        private void Negative_click(object sender, EventArgs e)
        {
            UploadedImageBitmap.BM = ImageFilter.DrawAsNegative(UploadedImageBitmap.BM);
            pictureBox1.Image = UploadedImageBitmap.BM;

        }

        private void Laplacian_3x3(object sender, EventArgs e)
        {
            bool grayscale = false;
            UploadedImageBitmap.BM = ImageFilter.Laplacian3x3Filter(UploadedImageBitmap.BM, grayscale);
            pictureBox1.Image = UploadedImageBitmap.BM;
        }

        private void ReplaceColorButton(object sender, EventArgs e)
        {

           ImageFilter.ReplaceColor(UploadedImageBitmap.BM, Color.FromArgb(0, 0, 0), Color.Red);
            
           pictureBox1.Image = UploadedImageBitmap.BM;
           
        }


        private void DisplayMostReoccuringColor() 
        {

            Bitmap image = new Bitmap(50,50);

            Graphics gfx = Graphics.FromImage(image);

            Color color = ImageManipulation.FindTheMostReoccuringColor(new Bitmap(pictureBox1.Image));
            SolidBrush brush = new SolidBrush(color);

            gfx.FillRectangle(brush, 0, 0, 50,50);

            pictureBox4.Image =  image;

            textBox6.Text = color.ToString();

            UploadedImageBitmap.MainColor = color;

        }


        //webcam functionality

        private void Start_Click(object sender, EventArgs e)
        {
            videoSource.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (UploadedImageBitmap.BM != null) { UploadedImageBitmap.BM.Dispose(); }
            UploadedImageBitmap.BM = new Bitmap(pictureBox1.Image);

            if (UploadedImageBitmap.startBM != null) { UploadedImageBitmap.startBM.Dispose(); }
            UploadedImageBitmap.startBM = UploadedImageBitmap.BM;

            videoSource.Stop();
           
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            if (pictureBox1.Image != null) { pictureBox1.Image.Dispose(); }
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();

        }

      

        private void White_Outline_Highlight(object sender, EventArgs e)
        {
           
            var tempBM = ImageFilter.DrawOutlineFromLaplacian(UploadedImageBitmap.BM, Color.FromArgb(255, 255, 255), Color.Red);
            pictureBox1.Image = tempBM;
        }



    

        //when data is read from the JSON file
        public void UpdateTrackBarTextboxes(UserImage image)
        {
            textBox1.Text = Convert.ToString(image.brightness);
            textBox2.Text = Convert.ToString(image.contrast);
            textBox3.Text = Convert.ToString(image.saturation);
            textBox6.Text = Convert.ToString(image.MainColor);
            textBox7.Text = image.Category;
        }

        public void UpdateUserImageObject(UserImage image, UserImage UploadedImage)
        {
            UploadedImage.brightness = image.brightness;
            UploadedImage.contrast = image.contrast;
            UploadedImage.saturation = image.saturation;
            UploadedImage.filepath = image.filepath;
            UploadedImage.MainColor = image.MainColor;
            UploadedImage.Category = image.Category;
        
        }


        private void GetCategory(object sender, EventArgs e)
        {
            MLContext mlContext = new MLContext();
            ITransformer model = MachineLearning.GenerateModel(mlContext);
            MachineLearning._predictSingleImage = UploadedImageBitmap.filepath;

            textBox7.Text =  MachineLearning.ClassifySingleImage(mlContext, model)[0];

            UploadedImageBitmap.Category = MachineLearning.ClassifySingleImage(mlContext, model)[1];
            
        }

        private void recurringColorBoxClick(object sender, EventArgs e)
        {
            DisplayMostReoccuringColor();

        }

        private void openProgramDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Images");
        }

        private void SuggestedFilterBoxClick(object sender, EventArgs e)
        {
           
            pictureBox5.Image = ImageFilter.SuggestedFilter(UploadedImageBitmap);
            pictureBox1.Image = pictureBox5.Image;
        }

        private void Rotate90CW(object sender, EventArgs e)
        {  
            UploadedImageBitmap.BM = new Bitmap( ImageFilter.RotateImage90CW(pictureBox1.Image));
            pictureBox1.Image = UploadedImageBitmap.BM;
        }



        // AREA SELECTION

        // True when we're selecting a rectangle.
        private bool IsSelecting = false;

        // The area we are selecting.
        private int X0, Y0, X1, Y1;

        private void OpenComparison(object sender, EventArgs e)
        {
            var window = new ImageComparisonWindow();
            
            window.ShowDialog();
            
        }



        // Start selecting the rectangle.
        private void picOriginal_MouseDown(object sender, MouseEventArgs e)
        {
            IsSelecting = true;
            
            // Save the start point.
            X0 = e.X;
            Y0 = e.Y;
        }

        // Continue selecting.
        private void picOriginal_MouseMove(object sender, MouseEventArgs e)
        {
            
            // Do nothing if we're not selecting an area.
            if (!IsSelecting) return;

            // Save the new point.
            X1 = e.X;
            Y1 = e.Y;

            // Make a Bitmap to display the selection rectangle.
             Bitmap bm = new Bitmap(UploadedImageBitmap.BM);
           

            // Draw the rectangle.
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawRectangle(Pens.Red,
                    Math.Min(X0, X1), Math.Min(Y0, Y1),
                    Math.Abs(X0 - X1), Math.Abs(Y0 - Y1));   
            }

            // Display the temporary bitmap.
            pictureBox1.Image = bm;
     
        }

        // Finish selecting the area.
        private void picOriginal_MouseUp(object sender, MouseEventArgs e)
        {
            // Do nothing it we're not selecting an area.
            if (!IsSelecting) return;
            IsSelecting = false;

            // Display the original image.
            pictureBox1.Image = UploadedImageBitmap.BM;

            // Copy the selected part of the image.
            int width = Math.Abs(X0 - X1);
            int height = Math.Abs(Y0 - Y1);
            if ((width < 1) || (height < 1)) return;

            Bitmap area = new Bitmap(width, height);
            using (Graphics gr = Graphics.FromImage(area))
            {
                Rectangle source_rectangle = new Rectangle(Math.Min(X0, X1), Math.Min(Y0, Y1), width, height);
                
                Rectangle dest_rectangle = new Rectangle(0, 0, width, height);
               
                gr.DrawImage(UploadedImageBitmap.BM, dest_rectangle, source_rectangle, GraphicsUnit.Pixel);
            }

            // Display the result.
            pictureBox1.Image = area;
        }
    }
}
