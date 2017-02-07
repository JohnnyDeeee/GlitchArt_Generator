using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlitchArt_Generator
{
    class TijmenGlitch
    {
        public static float GetNoise(int x, int y,float scale,float min, float max) {
            float noise = (SimplexNoise.Generate(x* scale, y * scale) + 1) / 2;
            return noise;
        }

        public static Bitmap ApplyNoise(Bitmap inputBMP) {
            Bitmap newBMP = new Bitmap(inputBMP.Width, inputBMP.Height);
           
            for (int x = 0; x < inputBMP.Width; x++)
            {
                for (int y = 0; y < inputBMP.Height; y++)
                {                    
                    
                    float noise = GetNoise(x, y, 20f, 1f, 1f);
                    newBMP.SetPixel(x, y, GenColor(noise));
                }
            }

            return newBMP;

        }

        public static Color GenColor(float noise)
        {
            int grayscale = (int)(noise * 256);
            Color newColor = Color.FromArgb(grayscale, grayscale, grayscale);
            return newColor;
        }

    }
}
