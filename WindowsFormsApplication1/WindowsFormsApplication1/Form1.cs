using System;
using System.Diagnostics;
using System.Drawing;
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
            var stopwatch = new Stopwatch();
            var kMeans = new KMeans((int) numericUpDownPointsCount.Value, (int) numericUpDownClassesCount.Value);
            kMeans.MaxX = pictureBox.Width;
            kMeans.MaxY = pictureBox.Height;
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.Black);
            stopwatch.Reset();
            stopwatch.Start();
            int iteration = kMeans.Calculate(g);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            MessageBox.Show(String.Format("Время выполнения: {0:00}:{1:00}.{2:0}\nКоличество итераций: {3}", ts.Minutes,
                ts.Seconds,
                ts.Milliseconds, iteration));
            g.Dispose();
        }
    }
}