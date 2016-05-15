using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Sphere : Circle
    {
        public Sphere(int X, int Y, int R) : base(X, Y, R)
        {
            x = X;
            y = Y;
            radius = R;
        }

        protected int z { get; set; }

        public new void Scale(float scale)
        {
            radius *= scale;
        }
    }
}
