using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlitchArt_Generator
{
    static class ArtMaker
    {
        public static Bitmap Tear(Bitmap OldMap)
        {
            Bitmap finalImage = new Bitmap (OldMap);
            Random rand = new Random();
            int tearPlace = rand.Next(1, 199);

            Color black = Color.FromArgb(0, 0, 0);


            for (int x = 0; x < OldMap.Height; x++)
            {

                for (int y = 0; y < OldMap.Width; y++)
                {
                    if (x == tearPlace)
                    {
                        finalImage.SetPixel(x, y, black);

                        int tearWidth = rand.Next(1, 10);
                        Color randomColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));

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

            return finalImage;

        }
    }
}