using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class Circle : Shape
    {
        protected override int x
        {
            get { return X; }
            set { X = value; }
        }

        protected override int y
        {
            get { return Y; }
            set { Y = value; }
        }

        public float Radius;

        protected float radius
        {
            get { return Radius; }
            set { Radius = value; }
        }

        public Circle(int X, int Y, int R)
        {
            x = X;
            y = Y;
            radius = R;
        }

        public override void Move(int X, int Y)
        {
            x += X;
            y += Y;
        }

        public override void Draw(Graphics picture, Pen tool1, Brush tool2)
        {
            picture.DrawEllipse(tool1, x, y, radius, radius);
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void Scale(float scale)
        {
            radius *= scale;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return "Circle with radius" + Radius + "\nPosition: X: " + X + " Y: " + Y;
        }
    }
}
