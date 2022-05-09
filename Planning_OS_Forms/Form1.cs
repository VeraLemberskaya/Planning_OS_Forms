using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Planning_OS_Forms
{
    public partial class Form1 : Form
    {

        private Planner _planner;
        private LotteryPlanner _lotteryPlanner;
        private List<Process> _processes = new List<Process>();
        private List<Process> _processesLottery = new List<Process>();
        private int quantum;
        private int quantumLottery;
        private int process_count;
        private int process_CountLottery;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void OnQueueChange(Object sender, QueueChangeEventArgs e)
        {
          
            _processes = e.Processes;
            Action action = () =>
            {
                dataGridView1.Rows.Clear();
                for(int i=0; i < _processes.Count; i++)
                {
                    Process process = _processes[i];
                    dataGridView1.Rows.Add(process.Id, process.TimeLeft, process.State);
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = process.Color;

                }
              
            };
            if (this.InvokeRequired) this.Invoke(action);
            else action();
        }

        private void OnLotteryChange(Object sender, LotteryChangeEventArgs e)
        {

            _processesLottery = e.Processes;
            Action action = () =>
            {
                dataGridView2.Rows.Clear();
                for(int i=0; i < _processesLottery.Count; i++)
                {
                    Process process = _processesLottery[i];
                    dataGridView2.Rows.Add(process.Id, process.GetTickets(), process.State, process.TimeLeft);
                    if(process.State == Planning_OS_Forms.State.Working)
                    {
                        dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                        dataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
                happyTicketLabel.Text = e.HappyTicket.ToString();
            };
            if (this.InvokeRequired) this.Invoke(action);
            else action();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(_planner.Start);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _planner.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int workTime;
            if(int.TryParse(newProcessTextBox.Text, out workTime)) _planner.Push(new Process(workTime, quantum));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isQuantumParsed = int.TryParse(quantumTextBox.Text, out quantum);
            process_count = trackBar1.Value;
            if (isQuantumParsed)
            {
                _processes.Clear();
                Random random = new Random();
                int min = quantum / 2;
                int max = quantum * 5;
                
                for (int i = 0; i < process_count; i++)
                {
                    Color color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    Process process = new Process(random.Next(min, max), quantum, color);
                    _processes.Add(process);
                }

                _planner = new Planner(_processes, quantum);
                _planner.QueueChange += OnQueueChange;

                Action action = () =>
                {
                    dataGridView1.Rows.Clear();
                    foreach(var process in _processes)
                    {
                        dataGridView1.Rows.Add(process.Id, process.TimeLeft, process.State);
                    }
                };
                if (this.InvokeRequired) this.Invoke(action);
                else action();
            }
        }

        private void quantumTextBox_TextChanged(object sender, EventArgs e)
        {
            quantumLabel.Text = ((TextBox)sender).Text;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            processCountLabel.Text = ((TrackBar)sender).Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ticketsCount;
            bool isQuantumParsed = int.TryParse(QuantumLottery.Text, out quantumLottery);
            bool isTicketsCountParsed = int.TryParse(ticketsCountTextBox.Text, out ticketsCount);
            process_CountLottery = trackBar2.Value;
            if (isQuantumParsed && isTicketsCountParsed)
            {
                _processesLottery.Clear();
                Random random = new Random();
                int min = quantumLottery / 2;
                int max = quantumLottery * 5;

                int min_tickets = 1;
                int max_tickets = ticketsCount;

                for (int i = 0; i < process_CountLottery; i++)
                {
                    Process process = new Process(random.Next(min, max), quantumLottery, random.Next(min_tickets, max_tickets+1));
                    _processesLottery.Add(process);
                }

                _lotteryPlanner = new LotteryPlanner(_processesLottery, quantumLottery);
                _lotteryPlanner.LotteryChange += OnLotteryChange;

                Action action = () =>
                {
                    dataGridView2.Rows.Clear();
                    foreach (var process in _processesLottery)
                    {
                        dataGridView2.Rows.Add(process.Id, process.TicketsCount, process.State, process.TimeLeft);
                    }
                };
                if (this.InvokeRequired) this.Invoke(action);
                else action();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(_lotteryPlanner.Start);
            thread.Start();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            processCountLottery.Text = ((TrackBar)sender).Value.ToString();
        }

        private void QuantumTextBoxLottery_TextChanged(object sender, EventArgs e)
        {
            QuantumLottery.Text = ((TextBox)sender).Text;
        }

        private void ticketsCountTextBox_TextChanged(object sender, EventArgs e)
        {
            TicketsCountLabel.Text = ((TextBox)sender).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _lotteryPlanner.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int workTime;
            int ticketCount;
            if (int.TryParse(newProcessLottery.Text, out workTime) && int.TryParse(ticketCountTextBox.Text, out ticketCount))
            {
                _lotteryPlanner.Push(new Process(workTime, quantumLottery, ticketCount));
            }
        }
    }
}
