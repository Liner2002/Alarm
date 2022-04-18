using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        private DateTime progress_start;

        private DateTime progress_end;

        private string mp3song = "Mellen Gi Remix (на будильник).mp3";

        private bool mp3_started = false;

        private bool started = false;

        private bool alarm_on = false;

        private List<UserControl1> userControl1s = new List<UserControl1>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string t in Properties.Settings.Default.timers)
            {
                DateTime dt = DateTime.Now;

                if (DateTime.TryParseExact(t, "HH:mm:ss", new CultureInfo("en-US"), DateTimeStyles.None, out dt))
                {
                    UserControl1 userControl1 = new UserControl1();

                    userControl1.Time.Text = t;

                    userControl1.timer_on = false;

                    userControl1.timer_string = t;

                    userControl1.timer_set = dt;

                    userControl1.checkBox1.Checked = false;

                    this.userControl1s.Add(userControl1);

                    this.flowLayoutPanel1.Controls.Add(userControl1);
                };
            }

            this.Стоп.Enabled = true;

            this.Time.Text = DateTime.Now.ToString("HH:mm:ss");

            for (int t = 0; t < 24; ++t)
            {
                this.Hour.Items.Add(t);
            }

            for (int t = 0; t < 60; ++t)
            {
                this.Minute.Items.Add(t);
            }

            for (int t = 0; t < 60; ++t)
            {
                this.Second.Items.Add(t);
            }
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            this.Time.Text = DateTime.Now.ToString("HH:mm:ss");

            DateTime dt = DateTime.Now;

            if (true)
            {
                foreach (var t in this.userControl1s)
                {
                    if (t.timer_on && t.IsDisposed == false)
                    {
                        this.progress_end = t.timer_set;

                        this.progress_start = t.progress_start;

                        int tics = (int)this.progress_end.Subtract(this.progress_start).TotalSeconds;

                        if (tics < 0) tics = 24 * 60 * 60 + tics;

                        int tics2 = (int)this.progress_end.Subtract(DateTime.Now).TotalSeconds;

                        if (tics2 < 0) tics2 = 24 * 60 * 60 + tics2;

                        int pro = 100 - (tics2 * 100 / tics);

                        if (pro > 100) pro = 100;

                        if (pro < 0) pro = 0;

                        this.progressBar1.Value = pro;

                        if (t.timer_set.Hour == dt.Hour)
                        {
                            if (t.timer_set.Minute == dt.Minute)
                            {
                                if (t.timer_set.Second == dt.Second)
                                {
                                    alarm_on = true;
                                }
                            }
                        }
                    }
                }
            }

            if (alarm_on)
            {
                if (!mp3_started)
                {
                    this.axWindowsMediaPlayer1.URL = mp3song;

                    this.mp3_started = true;
                }

                if (this.BackColor == Color.Red) this.BackColor = Color.Blue;

                else

                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = SystemColors.Control;

                this.axWindowsMediaPlayer1.URL = "";

                this.mp3_started = false;
            }

        }

        private void Hour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Стоп_Click(object sender, EventArgs e)
        {
            this.started = false;

            this.Стоп.Enabled = false;

            this.alarm_on = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h = int.Parse(this.Hour.Text);

            int m = int.Parse(this.Minute.Text);

            int s = int.Parse(this.Second.Text);

            UserControl1 userControl = new UserControl1();

            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, h, m, s);

            userControl.timer_set = dt;

            string btime = dt.ToString("HH:mm:ss");

            userControl.Time.Text = btime;

            this.flowLayoutPanel1.Controls.Add(userControl);

            this.userControl1s.Add(userControl);

            userControl.timer_string = btime;

            Properties.Settings.Default.timers.Add(btime);

            Properties.Settings.Default.Save();
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            int i = -1;

            foreach (string t in Properties.Settings.Default.timers)
            {
                if (((UserControl1)e.Control).timer_string == t)
                {
                    i = Properties.Settings.Default.timers.IndexOf(t);

                    
                }
            }
            if (i >= 0)
            {
                Properties.Settings.Default.timers.RemoveAt(i);

                Properties.Settings.Default.Save();
            }

            
        }
    }
}
