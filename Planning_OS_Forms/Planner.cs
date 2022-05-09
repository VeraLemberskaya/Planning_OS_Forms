using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;

namespace Planning_OS_Forms
{
    public class QueueChangeEventArgs
    {
        List<Process> processes;
        public QueueChangeEventArgs(List<Process> processes)
        {
            this.processes = processes;
        }

        public List<Process> Processes
        {
            get
            {
                return processes;
            }
        } 
    }

    public delegate void QueueChangeHandler(Object sender, QueueChangeEventArgs args);

    public class Planner
    {
        protected Queue<Process> _queue;
        protected int _quantum;
        protected Timer _timer;
        protected Process _activeProcess;
       

        public event QueueChangeHandler QueueChange;

        public Planner(List<Process> processes, int quantum)
        {
            SubscribeProcesses(processes);
            _queue = new Queue<Process>(processes);
            _quantum = quantum;
            _timer = new Timer(_quantum);
            _timer.Elapsed += OnTimeElapsed;
        }

        public void Push(Process process)
        {
            process.ProcessFinished += onProcessFinished;
            _queue.Enqueue(process);
            InvokeQueueChange();
        }

        public virtual void Start()
        {
            _timer.Start();
            _activeProcess = _queue.Peek();
            StartProcess(_activeProcess);
        }


      
        public void Stop()
        {
            _timer.Stop();
        }

        private void OnTimeElapsed(Object sender, ElapsedEventArgs e)
        {
            InvokeQueueChange();
            if (_queue.Count > 0)
            {
                Process process = _queue.Dequeue();
                process.Stop();

                if (!process.IsFinished) _queue.Enqueue(process);
                 _activeProcess = _queue.Peek();
                StartProcess(_activeProcess);
            }
            else _timer.Stop();
        }

        protected void StartProcess (Process activeProcess)
        {
            if (activeProcess.IsFinishing) _timer.Stop();
            activeProcess.Start();
            InvokeQueueChange();
            activeProcess.Work();
        }

        private void SubscribeProcesses(List<Process> processes)
        {
            foreach (var process in processes)
            {
                process.ProcessFinished += onProcessFinished;
            }
        }

        private void onProcessFinished(Object sender, ProcessFinishedEventArgs e)
        {
            _queue.Dequeue();
            InvokeQueueChange();
            if (_queue.Count > 0)
            {
                _activeProcess = _queue.Peek();
                _timer.Start();
                StartProcess(_activeProcess);
            }
            else _timer.Stop();
           
        }

        protected void InvokeQueueChange()
        {
            QueueChange?.Invoke(this, new QueueChangeEventArgs(new List<Process>(_queue)));
        }
    }
}
