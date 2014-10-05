using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class KMeans
    {
        private readonly List<CenterOfClass> centerOfClass;
        private readonly int centersCount;
        private readonly List<Color> colors;
        private readonly List<Vector> vectors;
        private readonly int vectorsCount;

        public KMeans(int n, int k)
        {
            centersCount = k;
            vectorsCount = n;
            colors = new List<Color>
            {
                Color.Red,
                Color.Blue,
                Color.Bisque,
                Color.Green,
                Color.Aqua,
                Color.BlueViolet,
                Color.Teal,
                Color.RoyalBlue,
                Color.Salmon,
                Color.Sienna,
                Color.PowderBlue,
                Color.Plum,
                Color.Firebrick,
                Color.DeepPink,
                Color.ForestGreen,
                Color.LawnGreen,
                Color.DodgerBlue,
                Color.MidnightBlue,
                Color.LightSalmon,
                Color.Khaki,
                Color.Olive,
                Color.Yellow,
                Color.YellowGreen,
                Color.Violet
            };
            vectors = new List<Vector>();
            centerOfClass = new List<CenterOfClass>();
        }

        public int MaxX { get; set; }
        public int MinX { get; set; }
        public int MaxY { get; set; }
        public int MinY { get; set; }


        private void Average(CenterOfClass center)
        {
        }

        private double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        private void Deviation()
        {
        }

        private void CreateVectors(int n)
        {
            var rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                var p = new Vector();
                p.point.X = rnd.Next(MinX, MaxX);
                p.point.Y = rnd.Next(MinY, MaxY);
                p.Class = null;
                p.SetColor(Color.Pink);
                vectors.Add(p);
            }
        }

        private void CreateCenteresOfClasses(int k)
        {
            int i = 0;

            var rnd = new Random();
            while (i < k)
            {
                Vector vector;
                CenterOfClass center;
                bool isEqual;
                vector = vectors[rnd.Next(vectorsCount)];
                isEqual = false;
                for (int j = 0; j < centerOfClass.Count; j++)
                {
                    center = centerOfClass[j];
                    if (vector.point.Equals(center.point))
                    {
                        isEqual = true;
                        break;
                    }
                }
                if (!isEqual)
                {
                    center = new CenterOfClass();
                    center.point = vector.point;
                    center.SetColor(colors[i]);
                    centerOfClass.Add(center);
                    i++;
                }
            }
        }

        private bool FindNewCenters()
        {
            bool result = false;
            foreach (CenterOfClass center in centerOfClass)
            {
                if (center.ChangedCenter())
                {
                    result = true;
                }
            }
            return result;
        }

        private void RecalculateClasses()
        {
            for (int i = 0; i < vectorsCount; i++)
            {
                Vector vector;
                vector = vectors[i];
                for (int j = 0; j < centersCount; j++)
                {
                    CenterOfClass center;
                    center = centerOfClass[j];
                    if (vector.Class == null)
                    {
                        center.AddVector(vector);
                        vector.Class = center;
                        vector.SetColor(centerOfClass[j].GetColor());
                    }
                    else
                    {
                        if (Distance(vector.point, center.point) <
                            Distance(vector.point, vector.Class.point))
                        {
                            vector.Class.RemoveVector(vector);
                            vector.Class = center;
                            center.AddVector(vector);
                            vector.SetColor(center.GetColor());
                        }
                    }
                }
            }
         /*   Parallel.ForEach(vectors, vector =>
            {
                Parallel.ForEach(centerOfClass, center =>
                {
                    if (vector.Class == null)
                    {
                        center.AddVector(vector);
                        vector.Class = center;
                        vector.SetColor(center.GetColor());
                    }
                    else
                    {
                        if (Distance(vector.point, center.point) <
                            Distance(vector.point, vector.Class.point))
                        {
                            vector.Class.RemoveVector(vector);
                            vector.Class = center;
                            center.AddVector(vector);
                            vector.SetColor(center.GetColor());
                        }
                    }
                });
            });*/
        }

        public void Calculate(Graphics g)
        {
            CreateVectors(vectorsCount);
            CreateCenteresOfClasses(centersCount);
            RecalculateClasses();
            Draw(g);
            while (FindNewCenters())
            {
                RecalculateClasses();
                Draw(g);
            }
        }

        private void Draw(Graphics g)
        {
            IntPtr hdc = g.GetHdc();
            foreach (Vector vector in vectors)
            {
                vector.Draw(hdc);
            }
           /* Parallel.ForEach(vectors, vector => { vector.Draw(hdc); });
            Parallel.ForEach(centerOfClass, center => { center.Draw(hdc); });*/
            g.ReleaseHdc(hdc);
        }
    }
}