using BackgroundThreads;

namespace QueueBackgroundWorkerDemo
{
    public partial class MainForm : Form
    {
        private QueueBackgroundWorker _workerThread;
        private QueueBackgroundWorker _workerThread2;
        private bool _closing = false;
        public MainForm()
        {
            InitializeComponent();

            _workerThread = new QueueBackgroundWorker(this);
            _workerThread.OnWork += WorkerThread_OnWork;

            _workerThread2 = new QueueBackgroundWorker();
            _workerThread2.AsyncEvent = false;
            _workerThread2.OnWork += WorkerThread2_OnWork;
        }
        private void WorkerThread_OnWork(WorkerMessage message)
        {
            if ((!_closing) && (message != null))
            {
                lblResult.Text = message.Message.ToString();
            }
        }

        private void WorkerThread2_OnWork(WorkerMessage message)
        {
            if (!_closing && (message != null) && (_workerThread != null))
            {
                _workerThread.Enqueue(new WorkerMessage(message.Message * 2, 0, 0));
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _closing = true;
            _workerThread.Stop();
            _workerThread2.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _workerThread2.Enqueue(new WorkerMessage(decimal.ToUInt32(nudValue.Value), 0, 0));
        }
    }
}