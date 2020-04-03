using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace project
{

    public class UserImage : ImageFilter
    {
        public string filepath { get; set; }
        public string Category { get; set; }
        public Color MainColor { get; set; }

        static List<string> categories = new List<string>();
        public int brightness { get; set; }
        public int contrast { get; set; }
        public int saturation { get; set; }

        [JsonIgnore]
        public Bitmap BM { get; set; }

       [JsonIgnore]
        public Bitmap startBM { get; set; }
        

        public UserImage()
        {
            string category = "";
            
            
            filepath =  filepath; 
            
            Category = category;
            categories.Add(category);
            startBM = new Bitmap(1, 1);
            BM = new Bitmap(1,1);
            brightness = 1;
            contrast = 1;
            saturation = 1;
           

        }

        public void Display() 
        {
            Console.WriteLine( filepath + " , " + Category + "Brightness: " + brightness + " , " 
                                + "Contrast: " + contrast + " , " + "Saturation: " + saturation);
                    
        }

        public List<UserImage> check_JSON() 
        {
            List<UserImage> Result = new List<UserImage>();

            if (File.Exists(@"data.json"))
            {
                string existingData;
                //using (StreamReader reader = new StreamReader(@"D:\Images\data.json", Encoding.Default))
                using (StreamReader reader = new StreamReader(@"data.json", Encoding.Default))
                {
                    existingData = reader.ReadToEnd();
                }

                Result = JsonConvert.DeserializeObject<List<UserImage>>(existingData);
                
            }
            else
            {
                Result = new List<UserImage>();
            }

            return Result;
            

        }

        public void update_JSON(List<UserImage> Images)
        {
            string json = JsonConvert.SerializeObject(Images.ToArray(), Formatting.Indented);
            File.WriteAllText(@"data.json", json);
            
        }

    }
}
