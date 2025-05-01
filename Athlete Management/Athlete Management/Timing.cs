using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public Stopwatch Stopwatch;
        private Timer timer;
        public Athlete _currentAthlete; // The Athlete object being added or edited.
        public DatabaseHelper _dbHelper; // Instance of the DatabaseHelper to save the data.
        public TimeSpan time;

        public Timing()
        {
            InitializeComponent();
            Stopwatch = new Stopwatch();
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += timer1_Tick;
            _dbHelper = new DatabaseHelper("athletes.xml"); // Use the same XML file.


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Stopwatch.IsRunning)
            {
                Stopwatch.Start();
                timer.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Stopwatch.IsRunning)
            {
                Stopwatch.Stop();
                timer.Stop();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Stopwatch.Reset();
            lblTime.Text = "00:00:00:000";
            if (Stopwatch.IsRunning)
            {
                Stopwatch.Stop();
                timer.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = FormatTime(Stopwatch.Elapsed);
        }
        private string FormatTime(TimeSpan timeSpan)
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}",
                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            lblTime.Text = FormatTime(Stopwatch.Elapsed);
            // Try to parse the lblTime.Text into a TimeSpan
            
            string timeToSave = Stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.fff");
            TimeSpan.TryParse((string)timeToSave, out TimeSpan time);
            _currentAthlete.StopwatchTime = time;
            
            _dbHelper.UpdateAthlete(_currentAthlete);
            DialogResult = DialogResult.OK;
            
            Close();

        }
    }
}
