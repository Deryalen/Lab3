using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Torus : Ring
    {
        public Torus(int X, int Y, int IR, int OR) : base(X, Y, IR, OR)
        {
            x = X;
            y = Y;
            innerRadius = IR;
            radius = OR;
        }

        protected int z { get; set; }

        public new void Scale(float scale)
        {
            base.Scale(scale);
        }
    }
}
