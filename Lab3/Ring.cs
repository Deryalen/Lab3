using System;
using System.Drawing;

namespace Lab3
{
    class Ring : Shape
    {
        public float InnerRadius { get; set; }

        public Ring(float x, float y, float ir, float or) : base(x, y, or)
        {
            InnerRadius = ir;
        }

        public override double Square()
        {
            return Math.PI*(Math.Pow(Radius, 2) - Math.Pow(InnerRadius, 2));
        }

        public override double Perimeter()
        {
            return 2*Math.PI*(Radius - InnerRadius);
        }

        public override void Scale(float scale)
        {
            Radius *= scale;
            InnerRadius *= scale;
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
            picture.DrawEllipse(Pens.Black, X + (Radius - InnerRadius), Y + (Radius - InnerRadius), 2*InnerRadius, 2*InnerRadius);
        }
    }
}
