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
    }
}
