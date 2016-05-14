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
            get { return X; }
            set { Y = value; }
        }

        public int Radius;

        protected int radius
        {
            get { return Radius; }
            private set { Radius = value; }
        }

        public Circle(int X, int Y, int R)
        {
            x = X;
            y = Y;
            radius = R;
        }

        public void move(int X, int Y)
        {
            x += X;
            y += Y;
        }

        public override void Draw(Graphics picture, Circle toDraw, Pen tool)
        {
            picture.DrawEllipse(tool, toDraw);
        }
    }
}
