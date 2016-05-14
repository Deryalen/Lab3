using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Cylinder : Ring
    {
        public Cylinder(int X, int Y, int Z, int OR) : base(X, Y, Z, OR)
        {
            x = X;
            y = Y;
            z = Z;
            radius = OR;
            innerRadius = 0;
        }

        protected int height { get; set; }
        protected int z { get; set; }
    }
}
