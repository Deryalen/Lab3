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

        public override void Draw(Graphics picture, Pen tool1, Brush tool2)
        {
            Brush center = new SolidBrush(Color.White);
            Brush fill = new SolidBrush(color);
            picture.FillEllipse(fill, x, y, radius, radius);
            picture.FillEllipse(center, x + radius / 2 - innerRadius / 2, y + radius / 2 - innerRadius / 2, innerRadius, innerRadius);
        }
    }
}
