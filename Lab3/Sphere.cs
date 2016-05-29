using System;
using System.Drawing;

namespace Lab3
{
    class Sphere : Shape
    {
        public Sphere(float x, float y, float z, float r) : base(x, y, z, r) { }

        public override void Scale(float scale)
        {
            Radius *= scale;
        }

        public override double Perimeter()
        {
            return 2*Math.PI*Radius;
        }

        public override double Square()
        {
            return 4*Math.PI*Math.Pow(Radius, 2);
        }

        public void MoveTo(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return "Sphere with properties:\n" + "Radius :" + Radius + "\nCoordinates :" + X + " " + Y + " " + Z;
        }

        public override void Draw(Graphics picture)
        {
            picture.DrawEllipse(Pens.Black, X, Y, 2*Radius, 2*Radius);
            picture.DrawEllipse(Pens.Black, X, Y + Radius, 2*Radius, 2*Radius/10);

        }
    }
}
