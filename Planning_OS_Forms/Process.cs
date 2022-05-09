using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;

namespace Planning_OS_Forms
{
    public class ProcessFinishedEventArgs
    {
        private Process _process;
        public ProcessFinishedEventArgs(Process process)
        {
            _process = process;
        }

        public Process Process
        {
            get
            {
                return _process;
            }
        }
    }

    public delegate void ProcessFinishedEventHandler(Object sender, ProcessFinishedEventArgs args);

    public enum State
    {
        Waiting,
        Working
    }

    public class Process
    {
        private static int _count = 1;

        private int _workTime = 0;
        private int _quantum = 0;
        private int _id;
        private bool _isWorking;
        private State _state;
        private int _ticketsCount;
        private Color _color;
        private List<int> _tickets = new List<int>();

        public event ProcessFinishedEventHandler ProcessFinished;

        public Process(int workTime, int quantum)
        {
            this._id = _count++;
            this._workTime = workTime;
            this._quantum = quantum;
            _isWorking = false;
            _state = State.Waiting;
        }

        public Process(int workTime, int quantum, Color color)
        {
            this._id = _count++;
            this._workTime = workTime;
            this._quantum = quantum;
            _isWorking = false;
            _state = State.Waiting;
            _color = color;
        }

        public Process(int workTime, int quantum, int ticketsCount):this(workTime,quantum)
        {
            this._ticketsCount = ticketsCount;
        }

        public Color Color
        {
            get
            {
                return _color;
            }
        }

        public List<int> Tickets
        {
            set
            {
                this._tickets = value;
            }
            get
            {
                return _tickets;
            }
        }

        public int TicketsCount
        {
            get
            {
                return _ticketsCount;
            }
        }

        public int TimeLeft
        {
            get
            {
                return _workTime;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public State State
        {
            get
            {
                return _state;
            }
        }

        public bool IsFinishing
        {
            get
            {
                return _workTime - _quantum < 0;
            }
        }

        public bool IsFinished
        {
            get
            {
                return _workTime <= 0;
            }
        }

        public void Start()
        {
            _isWorking = true;
            _state = State.Working;

            int diff = _workTime - _quantum;
            if (diff < 0)
            {
                Timer timer = new Timer(_workTime);
                timer.Elapsed += (sender, e) =>
                {
                    Stop();
                    ProcessFinished?.Invoke(this, new ProcessFinishedEventArgs(this));
                    timer.Dispose();
                };
                timer.AutoReset = false;
                timer.Start();
            }

            //Work();
        }

        public void Stop()
        {
            _isWorking = false;
            _state = State.Waiting;
            _workTime -= _quantum;
        }

        public void Work()
        {
            while (_isWorking)
            {
                //do some work
            }
        }

        public string GetTickets()
        {
            string result = "";
            foreach(var ticket in _tickets)
            {
                result += ticket.ToString() + " ";
            }
            return result;
        }
    }
}
