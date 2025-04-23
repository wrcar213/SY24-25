using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athlete_Management
{
    public partial class Timing : Form
    {
        private Stopwatch stopwatch;
        private Timer timer;
        public Timing()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += timer1_Tick;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning) 
            {
                stopwatch.Start();
                timer.Start();
            } 
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                timer.Stop();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            lblTime.Text = "00:00:00:000";
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                timer.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = FormatTime(stopwatch.Elapsed);
        }
        private string FormatTime(TimeSpan timeSpan)
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}",
                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
        }
    }
}
