using System;
using System.Diagnostics;
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

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.dakov.net/";
            linkDakovNet.Links.Add(link);

            txtStarDate.Text = DateTime.Now.ToString("HH:mm:ss");

            MouseHook.Start();

            MouseHook.MouseActionLeftCick += new EventHandler(EventLeftCick);
            MouseHook.MouseActionMiddleCick += new EventHandler(EventMiddleCick);
            MouseHook.MouseActionRightCick += new EventHandler(EventRightCick);
            MouseHook.MouseActionWheel += new EventHandler(EventWheel);

            Closed += FormMain_Closed;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtDistance.Text = _totalDelta.ToString();
            txtLeftClicks.Text = _totalLeftClicks.ToString();
            txtRightClicks.Text = _totalRightClicks.ToString();
            txtScrollClicks.Text = _totalMiddleClicks.ToString();
        }

        private void FormMain_Closed(object sender, EventArgs e)
        {
            MouseHook.Start();
        }

        private void EventLeftCick(object sender, EventArgs e)
        {
            _totalLeftClicks += 1;

            txtLeftClicks.Text = _totalLeftClicks.ToString();
        }

        private void EventMiddleCick(object sender, EventArgs e)
        {
            _totalMiddleClicks += 1;

            txtScrollClicks.Text = _totalMiddleClicks.ToString();
        }

        private void EventRightCick(object sender, EventArgs e)
        {
            _totalRightClicks += 1;

            txtRightClicks.Text = _totalRightClicks.ToString();
        }

        private void EventWheel(object sender, EventArgs e)
        {
            _totalDelta += 3; // Magic number, 3 millimeter movement. :)

            txtDistance.Text = _totalDelta.ToString();
        }

        private void linkDakovNet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStarDate.Text = DateTime.Now.ToString("HH:mm:ss");

            _totalDelta = 0;
            _totalLeftClicks = 0;
            _totalRightClicks = 0;
            _totalMiddleClicks = 0;

            txtDistance.Text = _totalDelta.ToString();
            txtLeftClicks.Text = _totalLeftClicks.ToString();
            txtRightClicks.Text = _totalRightClicks.ToString();
            txtScrollClicks.Text = _totalMiddleClicks.ToString();
        }
    }
}