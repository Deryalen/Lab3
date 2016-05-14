using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Shape3D : Shape
    {
        abstract protected int z { get; set; }
    }
}
