using System;
using System.Drawing;

namespace Lab3
{
    class Circle : Shape
    {
        public Circle(float x, float y, float radius) : base(x, y, radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void MoveTo(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override void Draw(Graphics picture)
        {
            picture.DrawEllipse(Pens.Black, X, Y, 2*Radius, 2*Radius);
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void Scale(float scale)
        {
            Radius *= scale;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return "Circle with InnerRadius" + Radius + "\nPosition: X: " + X + " Y: " + Y;
        }
    }
}
