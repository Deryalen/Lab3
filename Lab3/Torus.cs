using System;
using System.Drawing;

namespace Lab3
{
    class Torus : Shape
    {
        public float Height { get; set; }
        public float InnerRadius { get; set; }
        public Torus(float x, float y, float or, float ir, float h) : base(x, y, or)
        {
            InnerRadius = ir;
            Height = h;
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

        public override double Square()
        {
            return 4*Math.PI*Math.PI*Radius*InnerRadius;
        }

        public override double Perimeter()
        {
            return 2*Math.PI*(Radius - InnerRadius);
        }

        public override string ToString()
        {
            return "Torus with properties\n" + "Radius :" + Radius + "\nCoordinates :" + X + " " + Y;
        }

        public override void Draw(Graphics picture)
        {
            picture.DrawEllipse(Pens.Black, X, Y, 2*Radius, Radius);
            picture.DrawEllipse(Pens.Black, X + (Radius - InnerRadius), Y + (Radius - InnerRadius), 2*InnerRadius, InnerRadius);
        }
    }
}
