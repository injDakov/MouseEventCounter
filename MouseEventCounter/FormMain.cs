using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MouseEventCounter
{
    public partial class FormMain : Form
    {
        private int _totalDelta;
        private int _totalLeftClicks;
        private int _totalRightClicks;
        private int _totalMiddleClicks;

        private DateTime StartDate;

        public FormMain()
        {
            InitializeComponent();

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.dakov.net/";
            linkDakovNet.Links.Add(link);

            StartDate = DateTime.Now;
            txtStarDate.Text = StartDate.ToString("HH:mm:ss");

            Timer timerElapsedTime = new Timer();

            timerElapsedTime.Tick += TimerElapsedTime_Tick;
            timerElapsedTime.Interval = 1000 * 60;
            timerElapsedTime.Enabled = true;
            timerElapsedTime.Start();

            MouseHook.Start();

            MouseHook.MouseActionLeftCick += new EventHandler(EventLeftCick);
            MouseHook.MouseActionMiddleCick += new EventHandler(EventMiddleCick);
            MouseHook.MouseActionRightCick += new EventHandler(EventRightCick);
            MouseHook.MouseActionWheel += new EventHandler(EventWheel);

            Closed += FormMain_Closed;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtWheelDistance.Text = _totalDelta.ToString();
            txtLeftClicks.Text = _totalLeftClicks.ToString();
            txtRightClicks.Text = _totalRightClicks.ToString();
            txtWheelClicks.Text = _totalMiddleClicks.ToString();
            txtElapsedTime.Text = "0";
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

            txtWheelClicks.Text = _totalMiddleClicks.ToString();
        }

        private void EventRightCick(object sender, EventArgs e)
        {
            _totalRightClicks += 1;

            txtRightClicks.Text = _totalRightClicks.ToString();
        }

        private void EventWheel(object sender, EventArgs e)
        {
            _totalDelta += 3; // Magic number, 3 millimeter movement. :)

            txtWheelDistance.Text = _totalDelta.ToString();
        }

        private void linkDakovNet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StartDate = DateTime.Now;
            txtStarDate.Text = StartDate.ToString("HH:mm:ss");

            _totalDelta = 0;
            _totalLeftClicks = 0;
            _totalRightClicks = 0;
            _totalMiddleClicks = 0;

            txtElapsedTime.Text = "0";

            txtWheelDistance.Text = _totalDelta.ToString();
            txtLeftClicks.Text = _totalLeftClicks.ToString();
            txtRightClicks.Text = _totalRightClicks.ToString();
            txtWheelClicks.Text = _totalMiddleClicks.ToString();
        }

        private void TimerElapsedTime_Tick(object sender, EventArgs e)
        {
            txtElapsedTime.Text = ((int)(DateTime.Now - StartDate).TotalMinutes).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string logFileName = "MouseEventCounter_Logs.txt";

            if (!File.Exists(logFileName))
            {
                File.Create(logFileName).Close();
            }

            var newLogLines = new List<string>
            {
                "---------------",
                string.Concat("Period: ", StartDate.ToString("MM.dd.yyyy HH:mm:ss") , " - ", DateTime.Now.ToString("MM.dd.yyyy HH:mm:ss")),
                string.Concat("Elapsed Time: " , ((int)(DateTime.Now - StartDate).TotalMinutes).ToString(), " minutes"),

                string.Concat("Wheel Distance: " ,  txtWheelDistance.Text, " mm"),
                string.Concat("Left Clicks: " , txtLeftClicks.Text),
                string.Concat("Right Clicks: ", txtRightClicks.Text),
                string.Concat("Wheel Clicks: ", txtWheelClicks.Text),
                Environment.NewLine
            };

            var existingFile = File.ReadAllLines(logFileName).ToList();

            newLogLines.AddRange(existingFile);

            File.WriteAllLines(logFileName, newLogLines);
        }
    }
}