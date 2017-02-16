using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlitchArt_Generator
{
    class Cluster
    {
        private Color color;
        private Vector2 position;

        public Color Color { get { return this.color; } }
        public Vector2 Position { get { return this.position; } }

        public Cluster(Color color, Vector2 position)
        {
            this.color = color;
            this.position = position;
        }
    }

    class Vector2
    {
        public int x, y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
