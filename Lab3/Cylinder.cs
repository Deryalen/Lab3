using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Cylinder : Ring
    {
        public Cylinder(int X, int Y, int Z, int OR) : base(X, Y, Z, OR)
        {
            x = X;
            y = Y;
            z = Z;
            radius = OR;
            innerRadius = 0;
        }

        protected float height { get; set; }
        protected int z { get; set; }

        public new double Area()
        {
            return Math.PI * Math.Pow(radius, 2) + height * Math.PI * radius * 2;
        }

        public new void Scale(float scale)
        {
            height *= scale;
            radius *= scale;
        }

        public override void Draw(Graphics picture, Pen tool1, Brush tool2)
        {
            picture.FillEllipse(tool2, x, y, radius, radius);
            picture.FillRectangle(tool2, x + 50, y + 50, 2 * (float)Math.PI * (float)radius, height);
        }
    }
}
