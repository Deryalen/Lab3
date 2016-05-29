using System;
using System.Drawing;

namespace Lab3
{
    class Cylinder : Shape
    {
        public float Height { get; set; }

        public Cylinder(float x, float y, float r, float h) : base(x, y, r)
        {
            Height = h;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius * Height;
        }

        public override double Square()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2) + Math.PI * Radius * Height;
        }

        public override void Scale(float scale)
        {
            Height *= scale;
            Radius *= scale;
        }

        public override string ToString()
        {
            return "Cylinder with properties:\n" + "Radius :" + Radius + "\nCoordinates :" + X + " " + Y + "\nHeight : " + Height;
        }

        public override void Draw(Graphics picture)
        {
            picture.DrawEllipse(Pens.Black, X, Y, 2*Radius, 2*Radius/5);
            picture.DrawEllipse(Pens.Black, X, Y + Height, 2*Radius, 2*Radius/5);
            picture.DrawLine(Pens.Black, X, Y + 2*Radius/10, X, Y + Height + 2*Radius/10);
            picture.DrawLine(Pens.Black, X + 2*Radius, Y+ 2*Radius/10, X +2*Radius, Y + 2*Radius/10 + Height);
        }
    }
}
