﻿using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;

namespace project
{
    public class ImageFilter : ImageManipulation
    {
        
        public static Bitmap AdjustBrightness(Bitmap image, float brightness)
        {
            float b = brightness / 2;
           

            ColorMatrix ColMat = new ColorMatrix(new float[][]
            {
                new float[]{ b,0,0,0,0},  //
                new float[]{ 0,b,0,0,0},
                new float[]{ 0,0,b,0,0},
                new float[]{ 0,0,0,1,0},
                new float[]{ 0,0,0,0,1},

                
            });

            return ApplyColorMatrix(image, ColMat);
        }

        public static Bitmap AdjustContrast(Bitmap image, float contrast)
        {
            float value = (contrast * 0.01f);
            float c = 1 + value;
            float t = (1.0f - c) / 2.0f;

            ColorMatrix ColMat = new ColorMatrix(new float[][]
            {
                new float[]{ c,0,0,0,0},  //R
                new float[]{ 0,c,0,0,0},  //G
                new float[]{ 0,0,c,0,0},  //B
                new float[]{ 0,0,0,1,0},  //A
                new float[]{ t,t,t,0,1},  //W

            });

            return ApplyColorMatrix(image,ColMat);

        }

        public static Bitmap AdjustSaturation(Bitmap image, float saturation)
        {
            float s =  saturation / 2;
            float lumR = 0.3086F;
            float lumG = 0.6094F;
            float lumB = 0.0820F;

            float sr = (1 - s) * lumR;
            float sg = (1 - s) * lumG;
            float sb = (1 - s) * lumB;

            ColorMatrix ColMat = new ColorMatrix(new float[][]
            {
                new float[]{ sr+s,sr,sr,0,0},  //R
                new float[]{ sg,sg+s,sg,0,0},  //G
                new float[]{ sb,sb,sb+s,0,0},  //B
                new float[]{ 0,0,0,1,0},  //A
                new float[]{ 0,0,0,0,1},  //W


            });

            return ApplyColorMatrix(image, ColMat);

        }


        public static Image SuggestedFilter(UserImage userImage) 
        {
            var color = userImage.MainColor;
            
            var category = userImage.Category;

            Bitmap suggested = new Bitmap(userImage.BM);

            if (category == "Nature")
            {

                // 3x3 Sharpening Filter
                double factor = 1.0;
                int bias = 0;

                double[,] filterMatrix =
                new double[,] { {  0, -1,  0, },
                        { -1,  5, -1, },
                        {  0, -1,  0, }, };

                int r = color.R;
                int g = color.G;
                int b = color.B;

                List<int> RGB = new List<int> { r, g, b };
                int maxIndex = RGB.IndexOf(RGB.Max());

                if (maxIndex == 0)
                {
                    ColorMatrix ColMat = new ColorMatrix(new float[][]
                    {
                        new float[]{ 1.8f,0,0,0,0},  //R red scaling factor 
                        new float[]{ 0,1.5f,0,0,0},  //G green scaling factor
                        new float[]{ 0,0,1,0,0},  //B blue scaling factor
                        new float[]{ 0,0,0,1,0},  //A alpha scaling factor
                        new float[]{ 0,0,0,0,1},  //W translations


                    });

                    suggested = ApplyColorMatrix(suggested, ColMat);
                    suggested = ConvolutionFilter(suggested, filterMatrix, factor, bias, false);
                }
                else if (maxIndex == 1)
                {
                    ColorMatrix ColMat = new ColorMatrix(new float[][]
                    {
                        new float[]{ 1,0,0,0,0},  //R red scaling factor 
                        new float[]{ 0,1.5f,0,0,0},  //G green scaling factor
                        new float[]{ 0,0,1.3f,0,0},  //B blue scaling factor
                        new float[]{ 0,0,0,1,0},  //A alpha scaling factor
                        new float[]{ 0,0,0,0,1},  //W translations


                    });

                    suggested = ApplyColorMatrix(suggested, ColMat);
                    suggested = ConvolutionFilter(suggested, filterMatrix, factor, bias, false);
                }
                else
                {
                    ColorMatrix ColMat = new ColorMatrix(new float[][]
                    {
                        new float[]{ 1,0,0,0,0},  //R red scaling factor 
                        new float[]{ 0,1.5f,0,0,0},  //G green scaling factor
                        new float[]{ 0,0,2,0,0},  //B blue scaling factor
                        new float[]{ 0,0,0,1,0},  //A alpha scaling factor
                        new float[]{ 0,0,0,0,1},  //W translations


                    });

                    suggested = ApplyColorMatrix(suggested, ColMat);
                    suggested =  AdjustSaturation(suggested,5);
                    suggested = ConvolutionFilter(suggested, filterMatrix, factor, bias, false);
                }
               
                
            }
            else if (category == "Urban")
            {
                 double factor = 1.0;

                 int bias = 0;
            // 3x3 Sharpening Filter
                double[,] filterMatrix =
                new double[,] { {  0, -1,  0, },
                        { -1,  5, -1, },
                        {  0, -1,  0, }, };

                suggested = ConvolutionFilter(suggested,filterMatrix,factor,bias,false);


           }

            else if (category == "Face")
            {


                double factor = 1.0 / 8.0;

                int bias = 0;
                // 5x5 Sharpening Filter
                 double[,] filterMatrix =
            new double[,] { { -1, -1, -1, -1, -1, },
                        { -1,  2,  2,  2, -1, },
                        { -1,  2,  8,  2,  1, },
                        { -1,  2,  2,  2, -1, },
                        { -1, -1, -1, -1, -1, }, };

            suggested = ConvolutionFilter(suggested, filterMatrix, factor, bias, false);
            }
                    
      
            return suggested;
          
        }



        public static Image RotateImage90CW(Image img)
        {
            Image rotated = img;

            if (img != null)
            {
                rotated.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            

            return  rotated;

        }


        public static Bitmap DrawAsGrayscale(Image sourceImage)
        {
            ColorMatrix colMat = new ColorMatrix(new float[][]
                                {
                            new float[]{.3f, .3f, .3f, 0, 0},
                            new float[]{.59f, .59f, .59f, 0, 0},
                            new float[]{.11f, .11f, .11f, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{0, 0, 0, 0, 1}
                                });

            return ApplyColorMatrix(sourceImage,colMat);
           
        }


        public static Bitmap DrawAsSepiaTone(Image sourceImage)
        {
            ColorMatrix colMat = new ColorMatrix(new float[][]
                       {
                        new float[]{.393f, .349f, .272f, 0, 0},
                        new float[]{.769f, .686f, .534f, 0, 0},
                        new float[]{.189f, .168f, .131f, 0, 0},
                        new float[]{0, 0, 0, 1, 0},
                        new float[]{0, 0, 0, 0, 1}
                       });

            return ApplyColorMatrix(sourceImage, colMat);
        }

        public static Bitmap DrawAsNegative(Image sourceImage)
        {
            ColorMatrix colMat = new ColorMatrix(new float[][]
                           {
                            new float[]{-1, 0, 0, 0, 0},
                            new float[]{0, -1, 0, 0, 0},
                            new float[]{0, 0, -1, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{1, 1, 1, 1, 1}
                           });

            return ApplyColorMatrix(sourceImage, colMat);
        }

        public static Bitmap ApplyColorMatrix(Image sourceImage, ColorMatrix colMat)
        {
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(colMat);

            Point[] points =
                {
                    new Point(0,0),
                    new Point(sourceImage.Width,0),
                    new Point(0,sourceImage.Height),
                };

            Rectangle rect = new Rectangle(0, 0, sourceImage.Width, sourceImage.Height);

            Bitmap bitmap = new Bitmap(sourceImage.Width, sourceImage.Height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(sourceImage, points, rect, GraphicsUnit.Pixel, attributes);

            }

            return bitmap;
        }

       

        public static Bitmap Laplacian3x3Filter(Bitmap sourceBitmap,
                      bool grayscale)
        {

            
            double[,] Laplacian3x3 = new double[,]
                                  { { -1, -1, -1, },
                                    { -1,  8, -1, },
                                    { -1, -1, -1, }, };

            Bitmap result = ConvolutionFilter(sourceBitmap, Laplacian3x3,1.0,0, grayscale);

            return result;

        }

        // replace one color with another
        public static void ReplaceColor(Bitmap bmp, Color oldColor, Color newColor)
        {
            var lockedBitmap = new LockedBitmap(bmp);
            lockedBitmap.LockBits();

            for (int y = 0; y < lockedBitmap.Height; y++)
            {
                for (int x = 0; x < lockedBitmap.Width; x++)
                {
                    if (lockedBitmap.GetPixel(x, y) == oldColor)
                    {
                        lockedBitmap.SetPixel(x, y, newColor);
                    }
                }
            }
            lockedBitmap.UnlockBits();

            
        }


        public static Bitmap DrawOutlineFromLaplacian(Bitmap bmp, Color oldColor, Color penColor)
        {
            Bitmap outputBM = new Bitmap(bmp.Width,bmp.Height);

            var lockedOutputBitmap = new LockedBitmap(outputBM);
            lockedOutputBitmap.LockBits();

            var lockedOrigBitmap = new LockedBitmap(bmp);
            lockedOrigBitmap.LockBits();

            
            Graphics g = Graphics.FromImage(outputBM);

            for (int y = 0; y < lockedOrigBitmap.Height; y++)
            {
                for (int x = 0; x < lockedOrigBitmap.Width; x++)
                {
                    for (int c = 255; c > 100 ; c--)
                    {
                        if (lockedOrigBitmap.GetPixel(x, y) == Color.FromArgb(c,c,c))
                        {
                            lockedOutputBitmap.SetPixel(x, y, penColor);
                        }
                    }
                    
                }
            }

            lockedOrigBitmap.UnlockBits();
            lockedOutputBitmap.UnlockBits();

            return outputBM;
        }





    }
}

