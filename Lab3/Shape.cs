using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    abstract class Shape
    {
        public int X;
        public int Y;
        abstract protected int x { get; set; }
        abstract protected int y { get; set; }

        abstract public void Draw(Graphics picture, Pen tool1, Brush tool2);
        abstract public void Move(int X, int Y);
        abstract public double Area();
        abstract public void Scale(float scale);
        abstract public double Perimeter();
        abstract public override string ToString();
    }
}
