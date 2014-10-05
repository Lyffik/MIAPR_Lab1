using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Vector
    {

        private Color color;
        public CenterOfClass Class;
        public Point point;

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
            return ((uint)(((uint)(color.R) | ((uint)(color.G) << 8)) | (((uint)(color.B)) << 16)));
        }
        public void Draw( IntPtr hdc)
        {
            //   g.DrawEllipse(new Pen(color), vector.X, vector.Y, 2, 2);
            SetPixel(hdc, point.X, point.Y, ColorToUInt(color));
        }
    }
}
