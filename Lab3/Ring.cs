using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Ring : Circle
    {
        public Ring(int X, int Y, int IR, int OR) : base(X, Y, IR)
        {
            x = X;
            y = Y;
            innerRadius = IR;
            radius = OR;
        }

        protected float innerRadius { get; set; }

        public override void Draw(Graphics picture, Pen tool1, Brush tool2)
        {
            picture.DrawEllipse(tool1, x, y, radius, radius);
            picture.DrawEllipse(tool1, x + radius/2 - innerRadius/2, y + radius/2 - innerRadius/2, innerRadius, innerRadius);
        }

        public new double Area()
        {
            return Math.PI * Math.Pow(Radius, 2) - Math.PI * Math.Pow(innerRadius, 2);
        }

        public new double Perimeter()
        {
            return 2 * Math.PI * (radius + innerRadius);
        }

        public new void Scale(float scale)
        {
            radius *= scale;
            innerRadius *= scale;
        }

        public override string ToString()
        {
            return "Ring with inner radius " + innerRadius + ", outer radius " + radius + "\nPosition: X: " + X + " Y: " + Y;
        }
    }
}
