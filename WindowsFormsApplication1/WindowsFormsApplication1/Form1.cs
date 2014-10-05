using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            KMeans kMeans = new KMeans((int)numericUpDownPointsCount.Value, (int)numericUpDownClassesCount.Value);
            kMeans.MaxX = pictureBox1.Width;
            kMeans.MaxY = pictureBox1.Height;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.Black);
            stopwatch.Reset();
            stopwatch.Start();
            kMeans.Calculate(g);
            stopwatch.Stop();
            label1.Text = stopwatch.Elapsed.ToString();
        }
    }
}
