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

        abstract public void Draw<T>(Graphics picture, T @object, Pen tool);
    }
}
