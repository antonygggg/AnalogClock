using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class FormMain : Form
    {
        private const int HOUR_12_IN_MINUTES = 12 * 60;
        private const int MINUTES_IN_HOUR = 60;
        private const int SECONDS_IN_MINUTE = 60;
        private const double RATIO_TO_RADIAN = Math.PI * 360.0 / 180.0;
        private readonly string defaultWindowsTextFormat;
        private Pen linesPen;
        private readonly SolidBrush centerCircleBrush;
        private int currentTime;

        public FormMain()
        {
            this.defaultWindowsTextFormat = "hh:mm";
            this.linesPen = new Pen(Color.Black, 3);
            this.centerCircleBrush = new SolidBrush(Color.Black);
            InitializeComponent();
            this.UpdateForm();
            //GC.Collect(GC.MaxGeneration, GCCollectionMode.Optimized, false);
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Default);
            while (DateTime.Now.Millisecond > 0)
            {
            }
            this.timerMain.Start();
        }

        private int GetTimeInMinutes()
        {
            return (DateTime.Now.Hour > 12) ? (DateTime.Now.Hour - 12) * 60 + DateTime.Now.Minute : DateTime.Now.Hour * 60 + DateTime.Now.Minute;
        }
        private void UpdateForm()
        {
            this.Text = DateTime.Now.ToString(this.defaultWindowsTextFormat);
            this.Invalidate();
        }

        // Funcions to calc the x and y ratio ( between -1 and 1 ) , default Sin and Cos uses radians so adaptation to degrees is needed
        private double GetXRatio(double time, double totalTime)
        {
            return Math.Sin(RATIO_TO_RADIAN * time / totalTime);
        }
        private double GetYRatio(double time, double totalTime)
        {
            return -1 * Math.Cos(RATIO_TO_RADIAN * time / totalTime);
        }
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            linesPen.Color = Color.Black;
            linesPen.Width = 3;

            // Hour indicator
            this.currentTime = this.GetTimeInMinutes();
            e.Graphics.DrawLine(this.linesPen, this.Size.Width / 2 - 7, this.Size.Height / 2 - 28, (this.Size.Width / 2 - 7 + (int)(this.GetXRatio(this.currentTime, HOUR_12_IN_MINUTES) * this.Size.Width / 4)), (this.Size.Height / 2 - 28 + (int)(this.GetYRatio(this.currentTime, HOUR_12_IN_MINUTES) * this.Size.Height / 4)));

            // Minute indicator
            this.linesPen.Color = Color.FromArgb(Color.Black.ToArgb() - Color.Gray.ToArgb());
            this.currentTime = DateTime.Now.Minute;
            e.Graphics.DrawLine(this.linesPen, this.Size.Width / 2 - 7, this.Size.Height / 2 - 28, (this.Size.Width / 2 - 7 + (int)(this.GetXRatio(this.currentTime, MINUTES_IN_HOUR) * this.Size.Width / 3.5)), (this.Size.Height / 2 - 28 + (int)(this.GetYRatio(this.currentTime, MINUTES_IN_HOUR) * this.Size.Height / 3.5)));

            // Second indicator
            this.linesPen.Color = Color.Gray;
            this.currentTime = DateTime.Now.Second;
            e.Graphics.DrawLine(this.linesPen, this.Size.Width / 2 - 7, this.Size.Height / 2 - 28, (this.Size.Width / 2 - 7 + (int)(this.GetXRatio(this.currentTime, SECONDS_IN_MINUTE) * this.Size.Width / 3)), (this.Size.Height / 2 - 28 + (int)(this.GetYRatio(this.currentTime, SECONDS_IN_MINUTE) * this.Size.Height / 3)));
            this.linesPen.Width = 5;
            e.Graphics.DrawLine(this.linesPen, this.Size.Width / 2 - 7, this.Size.Height / 2 - 28, (this.Size.Width / 2 - 7 - (int)(this.GetXRatio(this.currentTime, SECONDS_IN_MINUTE) * this.Size.Width / 10)), (this.Size.Height / 2 - 28 - (int)(this.GetYRatio(this.currentTime, SECONDS_IN_MINUTE) * this.Size.Height / 10)));

            // Close circle
            e.Graphics.FillEllipse(this.centerCircleBrush, this.Size.Width / 2 - 13, this.Size.Height / 2 - 34, 12, 12);

            //this.linesPen.Dispose();
            //formGraphics.Dispose();
        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            this.UpdateForm();
        }
    }
}
