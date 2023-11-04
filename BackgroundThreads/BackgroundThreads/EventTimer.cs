namespace BackgroundThreads
{
    public delegate void EventTimerOnTickHandler();

    /// <summary>
    /// The EventTimer class uses an Event to trigger the OnTick 
    /// event with a given time interval.
    /// The OnTick event can be executed in the main application 
    /// thread or in the context of the internal thread.
    /// </summary>
    public class EventTimer
    {
        private object _syncObj = new object();
        private bool _enabled = false;
        private bool _shouldStop = false;
        private bool _waiting = false;
        private int _interval = 1000;
        private bool _asyncEvent = true;
        private ManualResetEvent _event = new ManualResetEvent(false);
        private Thread? _thread;
        private Form? _parentForm;

        /// <summary>
        /// The OnTick event is triggered when a specified amount of time, determined by the Interval property, has passed.
        /// </summary>
        public event EventTimerOnTickHandler? OnTick;

        /// <summary>
        /// Set enable to true in order to trigger the OnTick event.
        /// </summary>
        public bool Enabled 
        {
            get { lock (_syncObj) return _enabled; }
            set { lock (_syncObj) {
                    if (!_shouldStop)
                    {
                        _enabled = value;
                    }                     
                } 
            } 
        }

        /// <summary>
        /// Time interval in milliseconds passed between each OnTick event.
        /// </summary>
        public int Interval
        {
            get { lock (_syncObj) return _interval; }
            set { lock (_syncObj) {
                    if (value > 0)
                    {
                        _interval = value;
                    }
                }
            }
        }

        /// <summary>
        /// ThreadIsAlive returns true when the internal thread is alive.
        /// </summary>
        public bool ThreadIsAlive { get { return (_thread != null) && _thread.IsAlive; } }

        private bool ShouldStop
        {
            get { lock (_syncObj) return _shouldStop; }
            set { 
                lock (_syncObj) {
                    if (!_shouldStop && value)
                    {
                        _shouldStop = true;
                        _enabled = false;
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
        /// When AsyncEvent is true the OnTick event is triggered asynchronously on the main application thread.
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
        /// This class constructor must be used when AsyncEvent is true.
        /// </summary>
        /// <param name="parentForm">Parent form instance used to execute the OnTick event in the main application thread.</param>
        public EventTimer(Form? parentForm)
        {
            _parentForm = parentForm;
            CreateThread();
        }

        /// <summary>
        /// This class constructor must be used when AsyncEvent is false.
        /// </summary>
        public EventTimer()
        {
            _parentForm = null;
            CreateThread();
        }

        private void CreateThread()
        {
            if (_thread == null)
            {
                _thread = new Thread(Run);
                _thread.Name = "EventTimerThread" + _thread.ManagedThreadId.ToString();
                _thread.Start();
            }
        }

        /// <summary>
        /// The parent form must call Stop before closing in order to destroy the internal thread.
        /// </summary>
        public void Stop()
        {
            OnTick = null;
            ShouldStop = true;
            if (_thread != null)
            {
                _thread.Join(1000);
                _thread = null;
            }
        }

        private void DoOnTick()
        {
            if (Enabled && (OnTick != null))
            {
                if (AsyncEvent)
                {
                    lock (_syncObj)
                    {
                        if (_parentForm != null)
                        {
                            _parentForm.BeginInvoke(OnTick);
                        }
                    }
                }
                else
                {
                    OnTick();
                }
            }
        }

        private bool CanContinue() { 
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

        private void Run()
        {
            while (CanContinue())
            {
                if (_event.WaitOne(Interval))
                {
                    Waiting = false;
                } 
                else 
                {
                    Waiting = false;
                    DoOnTick();
                }
            }
        }
    }
}
