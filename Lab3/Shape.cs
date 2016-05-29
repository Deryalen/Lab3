using System.Drawing;

namespace Lab3
{
    public abstract class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Radius { get; set; }
        public abstract double Square();

        protected Shape(float x = 0, float y = 0, float r = 0)
        {
            X = x;
            Y = y;
            Radius = r;
        }

        protected Shape(float x = 0, float y = 0, float z = 0, float r = 0)
        {
            X = x;
            Y = y;
            Z = z;
            Radius = r;
        }

        public abstract void Draw(Graphics picture);
        public abstract void Scale(float scale);
        public abstract double Perimeter();
        public abstract string ToString();
    }
}
