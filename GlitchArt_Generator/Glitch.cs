using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlitchArt_Generator
{
    // This class contains different glitch functions
    static class Glitch
    {        
        public static Form1 main;

        // Randomize pixel colors
        // TODO: Optimize (clusters are hogging the application around +40 chance)
        // TODO: Let this run on a different thread
        public static Bitmap RandomizePixelColors(Bitmap oldImage, int randomizeChance, int clusterChance, int clusterSize, bool randomClusterSize = false, int randClusterSize_min = 0, int randClusterSize_max = 0)
        {
            Random rand = new Random();
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

        //applys noise to al pixels of the provided bitmap
        public static Bitmap ApplyNoise(Bitmap inputBMP)
        {
            int currentStep = 0;
            int nextStep = (inputBMP.Width * inputBMP.Height) / 100;
            float clusterSize;
            //if clustersize == 0 it will fck shit up
            if (main.clusterSize > 0)
                clusterSize = (float)main.clusterSize;
            else
                clusterSize = 10;
            Bitmap newBMP = new Bitmap(inputBMP.Width, inputBMP.Height);
            
            for (int x = 0; x < inputBMP.Width; x++)
            {
                for (int y = 0; y < inputBMP.Height; y++)
                {
                    int x10 = (int)Math.Floor(x / clusterSize);
                    int y10 = (int)Math.Floor(y / clusterSize);
                    //exlude some spots of the img from noise and stetch it horizontal
                    if ((SimplexNoise.Generate(x10 * 0.01f, y10 * 0.0001f) + SimplexNoise.Generate(y10 * 0.1f, y10 * 0.1f)) > 1f)
                    {
                        float R = inputBMP.GetPixel(x, y).R;
                        float G = inputBMP.GetPixel(x, y).G;
                        float B = inputBMP.GetPixel(x, y).B;
                        //int red = (int)GetNoise(x10, y10, colorValue, 30f, 255f);
                        //int green = (int)GetNoise(x10, y10, colorValue, 33f, 255f);
                        //int blue = (int)GetNoise(x10, y10, colorValue, 27f, 255f);

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
                        main.progress.Increment(1);
                }
            }

            return newBMP;
        }
    }
}
