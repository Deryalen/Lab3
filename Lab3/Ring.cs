using System;
using System.Drawing;

namespace Lab3
{
    class Ring : Shape
    {
        public float radius { get; set; }

        public Ring(float x, float y, float ir, float or) : base(x, y, or)
        {
            radius = ir;
        }

        public override double Square()
        {
            return Math.PI*(Math.Pow(Radius, 2) - Math.Pow(radius, 2));
        }

        public override double Perimeter()
        {
            return 2*Math.PI*(Radius - radius);
        }

        public override void Scale(float scale)
        {
            Radius *= scale;
            radius *= scale;
        }

        public void MoveTo(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "Ring with properties:\n" + "Radius :" + Radius + "\nCoordinates :" + X + " " + Y;
        }

        public override void Draw(Graphics picture)
        {
            picture.DrawEllipse(Pens.Black, X, Y, 2*Radius, 2*Radius);
            picture.DrawEllipse(Pens.Black, X + (Radius - radius), Y + (Radius - radius), 2*radius, 2*radius);
        }
    }
}
