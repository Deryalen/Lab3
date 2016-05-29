
using System.Drawing;

namespace Lab3
{
    class RingColored : Ring
    {
        public  RingColored(float x, float y, float or, float ir) : base(x, y, or, ir) { }

        public new void Draw(Graphics picture)
        {
            picture.DrawEllipse(Pens.Black, X, Y, 2*Radius, 2*Radius);
            picture.FillEllipse(Brushes.Black, X, Y, 2*Radius, 2*Radius);
            picture.DrawEllipse(Pens.Black, X + (Radius - InnerRadius), Y - (Radius - InnerRadius), 2*InnerRadius, 2*InnerRadius);
        }
    }
}
