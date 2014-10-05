using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public class CenterOfClass
    {
        private readonly List<Vector> vectors = new List<Vector>();
        private Color color;
        public Point point;

        private Point Average()

        {
            long sumX = 0;
            long sumY = 0;
            foreach (Vector vector in vectors)
            {
                sumX += vector.point.X;
                sumY += vector.point.Y;
            }
            if (vectors.Count > 0)
            {
                return new Point((int)(sumX / vectors.Count), (int)(sumY / vectors.Count));
            }
            return point;
        }

        private double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public bool ChangedCenter()
        {
            bool changed = false;
            Point averagePoint = Average();

            for (int i = 0; i < vectors.Count; i++)
            {
                if (Distance(vectors[i].point, averagePoint) < Distance(point, averagePoint))
                {
                    changed = true;
                    point = vectors[i].point;
                }
            }
            return changed;
        }

        public void AddVector(Vector vector)
        {
            vectors.Add(vector);
        }

        public void RemoveVector(Vector vector)
        {
            vectors.Remove(vector);
        }

        public void ClearVectors()
        {
            vectors.Clear();
        }

        public void SetColor(Color clr)
        {
            color = clr;
        }

        public Color GetColor()
        {
            return color;
        }

        [DllImport("gdi32.dll")]
        private static extern uint SetPixel(IntPtr hdc, int X, int Y, uint crColor);

        private static uint ColorToUInt(Color color)
        {
            return (color.R | ((uint)(color.G) << 8)) | (((uint)(color.B)) << 16);
        }

        public void Draw( IntPtr hdc)
        {
            //   g.DrawEllipse(new Pen(color), vector.X, vector.Y, 2, 2);
            SetPixel(hdc, point.X, point.Y, ColorToUInt(color));
        }
    }
}