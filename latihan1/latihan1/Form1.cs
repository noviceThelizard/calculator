using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hostile_L.Text = "┴";
            friendly_L.ForeColor = System.Drawing.Color.FromArgb(34,34,34);
            hostile_L.ForeColor = System.Drawing.Color.FromArgb(191,181,86);
            TDC_T.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            TDC_B.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            ChaseHorL.ForeColor = System.Drawing.Color.FromArgb(191, 181,86);
            ChaseHorR.ForeColor = System.Drawing.Color.FromArgb(191, 181, 86);
            ChaseRangeL.ForeColor = System.Drawing.Color.FromArgb(191, 181, 86);
            ChaseRangeR.ForeColor = System.Drawing.Color.FromArgb(191, 181, 86);
            ChaseRangeR.Location = new Point(299, 151);
            ChaseRangeL.Location = new Point(115, 151);
            for (int i=0; i<7; i++)
            {
                ChaseRangeR.Location = new Point(ChaseRangeR.Location.X - 10, 151);
                ChaseRangeL.Location = new Point(ChaseRangeL.Location.X + 8, 151);
                if (i == 2)
                {
                    HR_L.BackColor = System.Drawing.Color.FromArgb(204, 137, 109);
                }
                if (i == 4)
                {
                    LNCH_L.BackColor = System.Drawing.Color.FromArgb(204, 137, 109);
                }
                if (i == 6)
                {
                    Break_L.BackColor = System.Drawing.Color.FromArgb(204, 137, 109);
                    LNCH_L.BackColor = System.Drawing.Color.FromArgb(158, 86, 65);
                }
                wait(1000);
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radarOn_B_Click(object sender, EventArgs e)
        {
            
        }

        private void iff_B_Click(object sender, EventArgs e)
        {
            friendly_L.Text = "_\n-";
            hostile_L.Text = "-";
            ChaseHorL.ForeColor = ChaseHorL.BackColor;
            ChaseHorR.ForeColor = ChaseHorR.BackColor;
            ChaseRangeL.ForeColor = ChaseRangeL.BackColor;
            ChaseRangeR.ForeColor = ChaseRangeR.BackColor;
            friendly_L.ForeColor = System.Drawing.Color.FromArgb(191, 181, 86);
            hostile_L.ForeColor = System.Drawing.Color.FromArgb(191, 181, 86);
            HR_L.BackColor = System.Drawing.Color.FromArgb(158, 86, 65);
            LNCH_L.BackColor = System.Drawing.Color.FromArgb(158, 86, 65);
            Break_L.BackColor = System.Drawing.Color.FromArgb(158, 86, 65);
        }

        private void reset_B_Click(object sender, EventArgs e)
        {

        }

        private void radarBeam_B_Click(object sender, EventArgs e)
        {

        }

        private void radarDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void radarOn_B_Click_1(object sender, EventArgs e)
        {
            friendly_L.ForeColor = System.Drawing.Color.FromArgb(191,181,86);
            hostile_L.ForeColor = System.Drawing.Color.FromArgb(191,181,86);
            TDC_B.ForeColor = System.Drawing.Color.FromArgb(191, 181, 86);
            TDC_T.ForeColor = System.Drawing.Color.FromArgb(191, 181, 86);
            HR_L.BackColor = System.Drawing.Color.FromArgb(158,86,65);
            LNCH_L.BackColor = System.Drawing.Color.FromArgb(158, 86, 65);
            Break_L.BackColor = System.Drawing.Color.FromArgb(158, 86, 65);
            RadarDisp.ForeColor = System.Drawing.Color.FromArgb(204, 137, 109);
            ChaseHorL.ForeColor = ChaseHorL.BackColor;
            ChaseHorR.ForeColor = ChaseHorR.BackColor;
            ChaseRangeL.ForeColor = ChaseRangeL.BackColor;
            ChaseRangeR.ForeColor = ChaseRangeR.BackColor;
            ChaseRangeR.Location = new Point(299, 161);
            ChaseRangeL.Location = new Point(115, 161);
            friendly_L.Text = "┼";
            hostile_L.Text = "┴";

        }

        private void headReadyLight_L_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TDC_B_Click(object sender, EventArgs e)
        {

        }
    }
}
