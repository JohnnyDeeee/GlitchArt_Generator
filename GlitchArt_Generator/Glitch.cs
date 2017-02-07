using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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

        // Randomize pixel colors
        // TODO: Optimize (clusters are hogging the application around +40 chance)
        // TODO: Use NewRandomize function to improve this one
        // TODO: Let this run on a different thread
        public static Bitmap RandomizePixelColors(Bitmap oldImage, int randomizeChance, int clusterChance, int clusterSize, bool randomClusterSize = false, int randClusterSize_min = 0, int randClusterSize_max = 0)
        {
            int currentStep = 0;
            int nextStep = (oldImage.Width * oldImage.Height) / 100;
            Bitmap finalImage = new Bitmap(oldImage.Width, oldImage.Height);
            List<KeyValuePair<Color, List<KeyValuePair<int, int>>>> clusters = new List<KeyValuePair<Color, List<KeyValuePair<int, int>>>>();
            for (int x = 0; x < oldImage.Width; x++)
            {
                for (int y = 0; y < oldImage.Height; y++)
                {
                    Color pixelColor = oldImage.GetPixel(x, y);
                    Color newColor = pixelColor;

                    // Create a random colored pixel
                    if (rand.Next(0, 101) < randomizeChance &&
                        clusters.Find(_x => _x.Value.Contains(new KeyValuePair<int, int>(x, y))).Equals(new KeyValuePair<Color, List<KeyValuePair<int, int>>>()))
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
                            List<KeyValuePair<int, int>> clusterPixels = new List<KeyValuePair<int, int>>();
                            for (int _x = x; _x < (x + clusterSize); _x++)
                            {
                                for (int _y = y; _y < (y + clusterSize); _y++)
                                {
                                    clusterPixels.Add(new KeyValuePair<int, int>(_x, _y));
                                }
                            }

                            clusters.Add(new KeyValuePair<Color, List<KeyValuePair<int, int>>>(clusterColor, clusterPixels));
                        }
                    }
                    else if (!clusters.Find(_x => _x.Value.Contains(new KeyValuePair<int, int>(x, y))).Equals(new KeyValuePair<Color, List<KeyValuePair<int, int>>>()))
                        newColor = clusters.Find(_x => _x.Value.Contains(new KeyValuePair<int, int>(x, y))).Key;
                    else
                        newColor = oldImage.GetPixel(x, y);

                    // Save the new pixel to the new bitmap
                    finalImage.SetPixel(x, y, newColor);

                    currentStep++;

                    // Increment progressbar on every nextStep
                    if (currentStep % nextStep == 0)
                        main.progress.Increment(1);
                }
            }

            return finalImage;
        }

        // Shift bytes
        public static Bitmap NewRandomColorPixels(Bitmap oldImage)
        {
            // Create a copy from the old image
            Bitmap newImage = new Bitmap(oldImage);
            
            // Get the bytes from the bitmap
            BitmapData bitmapData = newImage.LockBits(new Rectangle(0, 0, newImage.Width, newImage.Height), ImageLockMode.ReadWrite, newImage.PixelFormat);
            IntPtr ptr = bitmapData.Scan0; // Get the adress of the first line
            int amountBytes = Math.Abs(bitmapData.Stride) * newImage.Height;
            byte[] bytes = new byte[amountBytes];

            // Copy bytes to the new array
            Marshal.Copy(ptr, bytes, 0, amountBytes);

            // Loopt trough the bytes
            for (int i = 0; i < bytes.Length; i+=3)
            {
                bytes[i] = unchecked((Byte)(bytes[i] << rand.Next(0, 6)));
            }

            // Copy new bytes back to the bitmap
            Marshal.Copy(bytes, 0, ptr, amountBytes);

            // Unlock bits
            newImage.UnlockBits(bitmapData);

            // Return new bitmap
            return newImage;
        }

        // Drag out pixel color
        public static Bitmap DragOutPixels(Bitmap oldImage)
        {
            // Create a copy from the old image
            Bitmap newImage = new Bitmap(oldImage);

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
                Color pixelColor = Color.FromArgb(bytes[i+3], bytes[i+2], bytes[i+1], bytes[i]);

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

            return newImage;
        }
    }
}
