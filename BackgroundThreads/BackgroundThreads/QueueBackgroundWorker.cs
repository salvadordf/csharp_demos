namespace BackgroundThreads
{
    /// <summary>
    /// The WorkerMessage class is stored in the Queue list.
    /// The meaning of the properties is decided by the application.
    /// </summary>
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

    /// <summary>
    /// QueueBackgroundWorker uses an internal thread and a queue list to store custom messages.
    /// The application can handle the current message in the OnWork event.
    /// </summary>
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

        /// <summary>
        /// The OnWork event is triggered whenever there's a pending message in the queue.
        /// </summary>
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

        /// <summary>
        /// ThreadIsAlive returns true when the internal thread is alive.
        /// </summary>
        public bool ThreadIsAlive { get { return (_thread != null) && _thread.IsAlive; } }

        /// <summary>
        /// When AsyncEvent is true the OnWork event is triggered asynchronously on the main application thread.
        /// Otherwise it's executed in the context of the internal thread.
        /// </summary>
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

        /// <summary>
        /// This class constructor must be used when AsyncEvent is false.
        /// </summary>
        public QueueBackgroundWorker()
        {
            _parentForm = null;
            CreateThread();
        }

        /// <summary>
        /// This class constructor must be used when AsyncEvent is true.
        /// </summary>
        /// <param name="parentForm">Parent form instance used to execute the OnWork event in the main application thread.</param>
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

        /// <summary>
        /// The parent form must call Stop before closing in order to destroy the internal thread.
        /// </summary>
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

        /// <summary>
        /// Use the Enqueue method to add a message to the queue list. 
        /// </summary>
        /// <param name="message"></param>
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
