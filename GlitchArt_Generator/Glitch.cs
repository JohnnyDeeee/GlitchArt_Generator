using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GlitchArt_Generator
{
    // This class contains different glitch functions
    static class Glitch
    {        
        public static Form1 main;
        private static Random rand = new Random();

        // Author: Gerben
        // Randomize pixel colors
        // TODO: Optimize (clusters are hogging the application around +40 chance)
        // TODO: Use NewRandomize function to improve this one
        // TODO: Let this run on a different thread??
        public static void RandomizePixelColors()
        {
            Bitmap oldImage = (Bitmap)main.picture_original.Image;
            int randomizeChance = (int)main.RPC_numeric_randomPixelChance.Value;
            int randClusterSize_min = (int)main.RPC_numeric_randClustersize_min.Value;
            int randClusterSize_max = (int)main.RPC_numeric_randClustersize_max.Value;
            bool randomClusterSize = main.RPC_check_randomClustersize.Checked;
            int clusterSize = (int)main.RPC_numeric_clusterSize.Value;
            int clusterChance = (int)main.RPC_numeric_clusterChance.Value;
            int currentStep = 0;
            int nextStep = (oldImage.Width * oldImage.Height) / 100;
            Bitmap finalImage = new Bitmap(oldImage.Width, oldImage.Height);
            List<Cluster> clusters = new List<Cluster>();
            for (int x = 0; x < oldImage.Width; x++)
            {
                for (int y = 0; y < oldImage.Height; y++)
                {
                    Color pixelColor = oldImage.GetPixel(x, y);
                    Color newColor = pixelColor;

                    // Create a random colored pixel
                    if (rand.Next(0, 101) < randomizeChance && clusters.Find(_x => _x.Position.x == x && _x.Position.y == y) == null) //clusters.Find(_x => _x.Value.Contains(new KeyValuePair<int, int>(x, y))).Equals(new KeyValuePair<Color, List<KeyValuePair<int, int>>>())
                    {
                        newColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));

                        // Check cluster chance
                        if (rand.Next(0, 101) < clusterChance)
                        {
                            // Create cluster
                            Color clusterColor = newColor;

                            // Randomize cluster size
                            if (randomClusterSize)
                                clusterSize = rand.Next(randClusterSize_min, randClusterSize_max);

                            // 'Mark' pixels as cluster pixels
                            for (int _x = x; _x < (x + clusterSize); _x++)
                            {
                                for (int _y = y; _y < (y + clusterSize); _y++)
                                {
                                    clusters.Add(new Cluster(clusterColor, new Vector2(_x, _y)));
                                }
                            }
                        }
                    }
                    else if (clusters.Find(_x => _x.Position.x == x && _x.Position.y == y) != null)
                        newColor = clusters.Find(c => c.Position.x == x && c.Position.y == y).Color;
                    else
                        newColor = oldImage.GetPixel(x, y);

                    // Save the new pixel to the new bitmap
                    finalImage.SetPixel(x, y, newColor);

                    currentStep++;

                    // Increment progressbar on every nextStep
                    if (currentStep % nextStep == 0)
                        main.progressBar.Increment(1);
                }
            }

            main.picture_new.Image = finalImage;
        }

        // Author: Gerben
        // Shift bytes
        public static void NewRandomColorPixels()
        {
            // Create a copy from the old image
            Bitmap newImage = new Bitmap((Bitmap)main.picture_original.Image);

            // Get the bytes from the bitmap
            BitmapData bitmapData = newImage.LockBits(new Rectangle(0, 0, newImage.Width, newImage.Height), ImageLockMode.ReadWrite, newImage.PixelFormat);
            IntPtr ptr = bitmapData.Scan0; // Get the adress of the first line
            int amountBytes = Math.Abs(bitmapData.Stride) * newImage.Height;
            byte[] bytes = new byte[amountBytes];

            // Copy bytes to the new array
            Marshal.Copy(ptr, bytes, 0, amountBytes);

            // Loopt trough the bytes
            for (int i = 0; i < bytes.Length; i += 3)
            {
                bytes[i] = unchecked((Byte)(bytes[i] << rand.Next(0, 6)));
            }

            // Copy new bytes back to the bitmap
            Marshal.Copy(bytes, 0, ptr, amountBytes);

            // Unlock bits
            newImage.UnlockBits(bitmapData);

            main.picture_new.Image = newImage;
        }

        // Author: Gerben
        // Drag out pixel color
        public static void DragOutPixels()
        {
            // Create a copy from the old image
            Bitmap newImage = new Bitmap((Bitmap)main.picture_original.Image);

            // Get the bytes from the bitmap
            BitmapData bitmapData = newImage.LockBits(new Rectangle(0, 0, newImage.Width, newImage.Height), ImageLockMode.ReadWrite, newImage.PixelFormat);
            IntPtr ptr = bitmapData.Scan0; // Get the adress of the first line
            int amountBytes = Math.Abs(bitmapData.Stride) * newImage.Height;
            byte[] bytes = new byte[amountBytes];
            
            // Copy bytes to the new array
            Marshal.Copy(ptr, bytes, 0, amountBytes);

            // Loopt trough the bytes (pixels) and save them in a list with their coordinates
            for (int i = 0; i < bytes.Length; i += 4)
            {
                //bytes[i] = 255; // Blue
                //bytes[i+1] = 255; // Green
                //bytes[i+2] = 255; // Red
                //bytes[i + 3] = 128; // Alpha
                Color pixelColor = Color.FromArgb(bytes[i + 3], bytes[i + 2], bytes[i + 1], bytes[i]);

                if (i + 7 <= bytes.Length && rand.Next(0, 101) < 60) // Probabillity of the dragout per pixel
                {
                    // Change the next pixel into this one
                    bytes[i + 4] = bytes[i];
                    bytes[i + 5] = bytes[i + 1];
                    bytes[i + 6] = bytes[i + 2];
                    bytes[i + 7] = bytes[i + 3];
                }
            }

            // Copy new bytes back to the bitmap
            Marshal.Copy(bytes, 0, ptr, amountBytes);

            // Unlock bits
            newImage.UnlockBits(bitmapData);

            main.picture_new.Image = newImage;
        }

        // Author: Tijmen
        //applys noise to al pixels of the provided bitmap
        public static void ApplyNoise()
        {
            Bitmap inputBMP = (Bitmap)main.picture_original.Image;
            int currentStep = 0;
            int nextStep = (inputBMP.Width * inputBMP.Height) / 100;
            float clusterSize;
            //if clustersize == 0 it will fck shit up
            if (main.AN_numeric_clusterSize.Value > 0)
                clusterSize = (float)main.AN_numeric_clusterSize.Value;
            else
                clusterSize = 10;
            Bitmap newBMP = new Bitmap(inputBMP.Width, inputBMP.Height);
           
            for (int x = 0; x < inputBMP.Width; x++)
            {
                for (int y = 0; y < inputBMP.Height; y++)
                {
                    //for each pixel do something

                    int x10 = (int)Math.Floor(x / clusterSize);
                    int y10 = (int)Math.Floor(y / clusterSize);
                    //exlude some spots of the img from noise and stetch it horizontal
                    if ((SimplexNoise.Generate(x10 * 0.01f, y10 * 0.0001f) + SimplexNoise.Generate(y10 * 0.1f, y10 * 0.1f)) > 1f)
                    {
                        //shif pixel colors acording to noise generated by position and color (a bit ecessive for aquired effect but w/e)
                        float R = inputBMP.GetPixel(x, y).R;
                        float G = inputBMP.GetPixel(x, y).G;
                        float B = inputBMP.GetPixel(x, y).B;
                        
                        int red = (int)SimplexNoise.GetNoise(x10, y10, R, 30f, 255f);
                        int green = (int)SimplexNoise.GetNoise(x10, y10, G, 30f, 255f);
                        int blue = (int)SimplexNoise.GetNoise(x10, y10, B, 30f, 255f);
                        newBMP.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                    else
                    {
                        newBMP.SetPixel(x, y, inputBMP.GetPixel(x, y));
                    }

                    currentStep++;

                    // Increment progressbar on every nextStep
                    if (currentStep % nextStep == 0)
                        main.progressBar.Increment(1);
                }
            }

            main.picture_new.Image = newBMP;
        }

        // Author: Tijmen
        public static void BitMosh()
        {
            //get the file pah of the selected image from main
            string filePath = main.fileDialog.FileName;
            Bitmap moshedImg;
            //open stream to img
            Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            //make a copy of the image to memory
            MemoryStream newMemoryStream = new MemoryStream();                                            
            stream.Position = 0;
            stream.CopyTo(newMemoryStream);
            stream.Dispose(); //image loaded to memory so this stream no lnger needed
            //for the number set in the fom control (from main) mess one byte up
            for (int i = 0; i < main.BM_numeric_randomChange.Value; i++)
            {
                //select an random bit (not imedeatly at the start or end becease these could be used for file type data)
                int pos = rand.Next(20, (int)(newMemoryStream.Length-20));                
                newMemoryStream.Position = pos;
                byte[] randBytes = new byte[1];
                rand.NextBytes(randBytes);
                newMemoryStream.WriteByte(randBytes[0]);                
            }

            //try to cast the file to bitmap (still uses the memory stream so don't close that)
            newMemoryStream.Position = 0;
            try
            {
                moshedImg = new Bitmap(newMemoryStream);
                main.picture_new.Image = moshedImg;
                
            }
            catch
            {
                Console.WriteLine("Failed converting moshed stream into Bitmap");
            }
            newMemoryStream.Close();
        }
            
            //author: Freddy
            public static void Tear()
            {

                Bitmap oldImage = (Bitmap)main.picture_original.Image;
                Bitmap finalImage = new Bitmap(oldImage);
                Random rand = new Random();
                //create the startplace for the tear
                int tearPlace = rand.Next(1, 199);
                // loop trough the bitmap
                for (int x = 0; x < oldImage.Width; x++)
                {
                    for (int y = 0; y < oldImage.Height; y++)
                    {
                        if (x == tearPlace)
                        {
                            //create the width of the tear and the color of the pixels
                            int tearWidth = rand.Next(1, 10);
                            Color randomColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                                    //loop through the width of the tear and set the pixel color, check to make sure the pixel doesn't exist outside the image
                                    for (int i = 0; i < tearWidth; i++)
                                    {
                                    if (x + i > finalImage.Width)
                                    {
                                        finalImage.SetPixel(finalImage.Width, y, randomColor);
                                    }
                                    else
                                    {
                                        finalImage.SetPixel(x + i, y, randomColor);
                                    }

                                    if (x - i < 0)
                                    {
                                        finalImage.SetPixel(0, y, randomColor);
                                    }
                                    else
                                    {
                                        finalImage.SetPixel(x - i, y, randomColor);
                                    }
                            }
                        }
                    }
                }
                 main.picture_new.Image = finalImage;
            }

        public static void Shrink()
        {
            Bitmap oldImage = (Bitmap)main.picture_original.Image;
            Bitmap finalImage = new Bitmap(oldImage);
            Random rand = new Random();
            Color White = Color.FromArgb(255,255,255);

            for (int x = 0; x < oldImage.Width; x++)
            {
                for (int y = 0; y < oldImage.Height; y++)
                {
                    Color a = oldImage.GetPixel(x,y);
                    finalImage.SetPixel(x, y, White);
                    finalImage.SetPixel(x/2 , y/2, a);
                }
            }

            main.picture_new.Image = finalImage;
            }

		}
     }
    
