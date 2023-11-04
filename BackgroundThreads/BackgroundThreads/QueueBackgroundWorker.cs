namespace BackgroundThreads
{
    public class WorkerMessage
    {
        public uint Message {  get; set; }
        public int LParam { get; set; }
        public uint WParam { get; set; }
        public WorkerMessage(uint message, int lParam, uint wParam) { 
            Message = message;
            LParam = lParam;
            WParam = wParam;
        }
    }

    public delegate void QueueWorkerThreadOnWorkHanler(WorkerMessage msg);

    public class QueueBackgroundWorker
    {
        private object _syncObj = new object();
        private bool _shouldStop = false;
        private bool _waiting = false;
        private bool _asyncEvent = true;
        private ManualResetEvent _event = new ManualResetEvent(false);
        private Thread? _thread;
        private Form? _parentForm;
        private Queue<WorkerMessage> _msgQueue = new Queue<WorkerMessage>();

        public event QueueWorkerThreadOnWorkHanler? OnWork;
        private bool ShouldStop
        {
            get { lock (_syncObj) return _shouldStop; }
            set
            {
                lock (_syncObj)
                {
                    if (!_shouldStop && value)
                    {
                        _shouldStop = true;
                        _parentForm = null;
                        if (_waiting)
                        {
                            _waiting = false;
                            _event.Set();
                        }
                    }
                }
            }
        }
        public bool ThreadIsAlive { get { return (_thread != null) && _thread.IsAlive; } }
        public bool AsyncEvent
        {
            get { lock (_syncObj) return _asyncEvent; }
            set { lock (_syncObj) _asyncEvent = value; }
        }
        private bool Waiting
        {
            get { lock (_syncObj) return _waiting; }
            set { lock (_syncObj) _waiting = value; }
        }
        public QueueBackgroundWorker()
        {
            _parentForm = null;
            CreateThread();
        }
        public QueueBackgroundWorker(Form? parentForm)
        {
            _parentForm = parentForm;
            CreateThread();
        }
        private void CreateThread()
        {
            if (_thread == null)
            {
                _thread = new Thread(Run);
                _thread.Name = "QueueBackgroundWorkerThread" + _thread.ManagedThreadId.ToString();
                _thread.Start();
            }
        }
        public void Stop()
        {
            OnWork = null;
            ShouldStop = true;
            if (_thread != null)
            {
                _thread.Join(1000);
                _thread = null;
            }
        }
        public void Enqueue(WorkerMessage message) {
            lock (_syncObj)
            {
                _msgQueue.Enqueue(message);
                if (_waiting) {
                    _waiting = false;
                    _event.Set();
                }
            }
        }
        private void DoOnWork(WorkerMessage message)
        {
            if (!ShouldStop && (OnWork != null))
            {
                if (AsyncEvent)
                {
                    lock (_syncObj)
                    {
                        if (_parentForm != null)
                        {
                            _parentForm.BeginInvoke(OnWork, message);
                        }
                    }
                }
                else
                {
                    OnWork(message);
                }
            }
        }
        private bool NextQueuedMessage(out WorkerMessage? message)
        {
            lock (_syncObj)
            {
                if (_msgQueue.Count > 0)
                {
                    message = _msgQueue.Dequeue();
                    return message != null;
                } 
                else 
                {
                    message = null;
                    return false;
                }
            }
        }
        private bool CanContinue()
        {
            lock (_syncObj)
            {
                if (_shouldStop)
                {
                    return false;
                }
                else
                {
                    _waiting = true;
                    _event.Reset();
                    return true;
                }
            }
        }
        private void ReadAllPendingMessages()
        {
            Waiting = false;
            if (!ShouldStop)
            {
                WorkerMessage? message;
                while (NextQueuedMessage(out message))
                {
                    if (message != null)
                    {
                        DoOnWork(message);
                    }
                }
            }
        }
        private void Run()
        {
            while (CanContinue())
            {
                _event.WaitOne();
                ReadAllPendingMessages();
            }
        }
    }
}
