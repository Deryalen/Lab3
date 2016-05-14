using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class RingColored : Ring
    {
        public RingColored(int X, int Y, int IR, int OR, Color paint) : base(X, Y, IR, OR)
        {
            x = X;
            y = Y;
            innerRadius = IR;
            radius = OR;
            color = paint;
        }

        public Color color { get; set; }
    }
}
