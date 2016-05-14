using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Ring : Circle
    {
        public Ring(int X, int Y, int IR, int OR) : base(X, Y, IR)
        {
            x = X;
            y = Y;
            innerRadius = IR;
            radius = OR;
        }

        protected int innerRadius { get; set; }
    }
}
