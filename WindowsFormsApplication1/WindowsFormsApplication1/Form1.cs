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
            labelTime.Text = "Выполняется...";
            kMeans.Calculate(g);
            stopwatch.Stop();
            labelTime.Text = stopwatch.Elapsed.ToString();
            g.Dispose();
        }
    }
}