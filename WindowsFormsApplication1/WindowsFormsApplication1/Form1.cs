using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            textBoxIteration.Clear();
            textBox.Clear();
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
            textBoxIteration.Text = Convert.ToString(kMeans.Calculate(g));
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            textBox.Text = String.Format("{0:00}:{1:00}.{2:0}", ts.Minutes, ts.Seconds, ts.Milliseconds);
           
            g.Dispose();
        }
    }
}