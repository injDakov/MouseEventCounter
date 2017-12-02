using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEventCounter
{
    public partial class FormMain : Form
    {
        private int _totalDelta;
        private int _totalLeftClicks;
        private int _totalRightClicks;
        private int _totalMiddleClicks;

        public FormMain()
        {
            InitializeComponent();

            //MouseWheel += Form_MouseWheel;
            //MouseClick += Form1_MouseClick;
            //MouseDoubleClick += Form1_MouseDoubleClick;

            MouseWheel += FormMain_MouseWheel;
            MouseClick += FormMain_MouseClick;
            MouseDoubleClick += FormMain_MouseDoubleClick;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtDistance.Text = _totalDelta.ToString();
            txtLeftClicks.Text = _totalLeftClicks.ToString();
            txtRightClicks.Text = _totalRightClicks.ToString();
            txtScrollClicks.Text = _totalMiddleClicks.ToString();
        }

        private void FormMain_MouseWheel(object sender, MouseEventArgs e)
        {
            // This guarantee every positive value with step 3. It's a magic number.
            _totalDelta = _totalDelta + (e.Delta >= 0 ? e.Delta : 0 - e.Delta) / 40;

            txtDistance.Text = _totalDelta.ToString();
        }

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            ClickCounter(e);
        }

        private void FormMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClickCounter(e);
        }

        private void ClickCounter(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _totalLeftClicks += 1;

                txtLeftClicks.Text = _totalLeftClicks.ToString();
            }

            if (e.Button == MouseButtons.Right)
            {
                _totalRightClicks += 1;

                txtRightClicks.Text = _totalRightClicks.ToString();
            }

            if (e.Button == MouseButtons.Middle)
            {
                _totalMiddleClicks += 1;

                txtScrollClicks.Text = _totalMiddleClicks.ToString();
            }
        }
    }
}