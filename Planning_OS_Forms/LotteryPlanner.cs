using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Planning_OS_Forms
{

    public class LotteryChangeEventArgs
    {
        private List<Process> processes;
        private int happyTicket;

        public LotteryChangeEventArgs(List<Process> processes, int ticket)
        {
            this.processes = processes;
            this.happyTicket = ticket;
        }

        public List<Process> Processes
        {
            get
            {
                return processes;
            }
        }

        public int HappyTicket
        {
            get
            {
                return happyTicket;
            }
        }
    }

    public delegate void LotteryChangeHandler(Object sender, LotteryChangeEventArgs args);

    public class LotteryPlanner
    {
        protected int _quantum;
        protected Timer _timer;
        protected Process _activeProcess;
        private List<Process> processes;
        private int _ticketsCount = 0;
        private int _happyTicket;

        public event LotteryChangeHandler LotteryChange;
        public LotteryPlanner(List<Process> processes, int quantum) 
        {

            SubscribeProcesses(processes);
            this.processes = processes;
            this._quantum = quantum;
            _timer = new Timer(_quantum);
            _timer.Elapsed += this.onTimeElapsed;
        }

        private void SubscribeProcesses(List<Process> processes)
        {
            foreach (var process in processes)
            {
                process.ProcessFinished += onProcessFinished;
            }
        }

        public  void Start()
        {
            CountTickets();
            PlayOutTickets();

            _activeProcess = ChooseActiveProcess();
            _timer.Start();
            StartProcess(_activeProcess);
        }

        public void Stop()
        {
            _timer.Stop();
        }

        public void Push(Process process)
        {
            process.ProcessFinished += onProcessFinished;
            processes.Add(process);
            CountTickets();
            PlayOutTickets();
            InvokeLotteryChange();
        }

        private void CountTickets()
        {
            _ticketsCount = 0;
            foreach (var process in processes)
            {
                _ticketsCount += process.TicketsCount;
            }
        }

        protected void StartProcess(Process activeProcess)
        {
            if (activeProcess.IsFinishing) _timer.Stop();
            activeProcess.Start();
            InvokeLotteryChange();
            activeProcess.Work();
        }

        private Process ChooseActiveProcess()
        {
            _happyTicket = ChooseRandomTicket();
            Process activeProcess = processes.Find((process) => process.Tickets.Contains(_happyTicket));
            return activeProcess;
        }

        private int ChooseRandomTicket()
        {
            Random random = new Random();
            return random.Next(0, _ticketsCount-1);
        }

        private void PlayOutTickets()
        {
            for (int i = 0; i < _ticketsCount; i++)
            {
                foreach (var process in processes)
                {
                    List<int> tickets = new List<int>();
                    int start = i;
                    for (int t = start; t < process.TicketsCount + start; t++)
                    {
                        tickets.Add(i);
                        i++;
                    }
                    process.Tickets = tickets;
                }
            }
        }

        private void onTimeElapsed(Object sender, ElapsedEventArgs e)
        {
            InvokeLotteryChange();
            if (processes.Count > 0)
            {
                _activeProcess.Stop();
                if (_activeProcess.IsFinished)
                {
                    processes.Remove(_activeProcess);
                    CountTickets();
                    PlayOutTickets();
                }
                if (processes.Count > 0)
                {
                    _activeProcess = ChooseActiveProcess();
                    StartProcess(_activeProcess);
                }
                else _timer.Stop();
            }
            else _timer.Stop();
        }

        private void onProcessFinished(Object sender, ProcessFinishedEventArgs e)
        {
            processes.Remove(_activeProcess);
            InvokeLotteryChange();
            if (processes.Count > 0)
            {
                CountTickets();
                PlayOutTickets();
                _activeProcess = ChooseActiveProcess();
                _timer.Start();
                StartProcess(_activeProcess);
            }
            else _timer.Stop();

        }
        protected void InvokeLotteryChange()
        {
            LotteryChange?.Invoke(this, new LotteryChangeEventArgs(processes, _happyTicket));
        }
    }
}
