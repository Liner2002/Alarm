using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class UserControl1 : UserControl
    {
        public bool timer_on = true;

        public string timer_string = "";

        public DateTime progress_start;

        public DateTime timer_set;
        public UserControl1()
        {
            InitializeComponent();

            this.progress_start = DateTime.Now;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.progress_start = DateTime.Now;

            this.timer_on = this.checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
