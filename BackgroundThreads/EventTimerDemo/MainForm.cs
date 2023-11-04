using BackgroundThreads;

namespace EventTimerDemo
{
    public partial class MainForm : Form
    {
        private EventTimer _eventTimer;
        private bool _closing = false;
        public MainForm()
        {
            InitializeComponent();
            _eventTimer = new EventTimer(this);
            _eventTimer.OnTick += EventTimer_OnTick;
            _eventTimer.Interval = 1000;
            _eventTimer.Enabled = true;
        }
        private void EventTimer_OnTick()
        {
            if (!_closing)
            {
                lblTimeValue.Text = DateTime.Now.ToString();
            }
        }

        private void chkTimerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            _eventTimer.Enabled = chkTimerEnabled.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _closing = true;
            _eventTimer.Stop();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            lblTimeValue.Text = DateTime.Now.ToString();
        }
    }
}