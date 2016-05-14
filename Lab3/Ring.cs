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

        protected int innerRadius { get; set; }

        public override void Draw(Graphics picture, Pen tool1, Brush tool2)
        {
            Brush center = new SolidBrush(Color.PowderBlue);
            picture.FillEllipse(tool2, x, y, radius, radius);
            picture.FillEllipse(center, x + radius/2 - innerRadius/2, y + radius/2 - innerRadius/2, innerRadius, innerRadius);
        }
    }
}
