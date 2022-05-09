namespace Planning_OS_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.newProcessTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.quantumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantumLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.newProcessLottery = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.QuantumLottery = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.QuantumTextBoxLottery = new System.Windows.Forms.TextBox();
            this.processCountLottery = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.ticketsCountTextBox = new System.Windows.Forms.TextBox();
            this.TicketsCountLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.happyTicketLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ticketCountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process,
            this.WorkTime,
            this.State});
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cyclic planning";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(219, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(17, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Push process";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newProcessTextBox
            // 
            this.newProcessTextBox.Location = new System.Drawing.Point(111, 28);
            this.newProcessTextBox.Name = "newProcessTextBox";
            this.newProcessTextBox.Size = new System.Drawing.Size(100, 20);
            this.newProcessTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.newProcessTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 113);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "WorkTime:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(402, 79);
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(237, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(402, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose number of processes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(399, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Process count: ";
            // 
            // processCountLabel
            // 
            this.processCountLabel.AutoSize = true;
            this.processCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processCountLabel.Location = new System.Drawing.Point(533, 234);
            this.processCountLabel.Name = "processCountLabel";
            this.processCountLabel.Size = new System.Drawing.Size(21, 24);
            this.processCountLabel.TabIndex = 10;
            this.processCountLabel.Text = "4";
            // 
            // quantumTextBox
            // 
            this.quantumTextBox.Location = new System.Drawing.Point(405, 172);
            this.quantumTextBox.Name = "quantumTextBox";
            this.quantumTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantumTextBox.TabIndex = 11;
            this.quantumTextBox.Text = "1000";
            this.quantumTextBox.TextChanged += new System.EventHandler(this.quantumTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(402, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Choose the quantum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(399, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantum: ";
            // 
            // quantumLabel
            // 
            this.quantumLabel.AutoSize = true;
            this.quantumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantumLabel.Location = new System.Drawing.Point(533, 276);
            this.quantumLabel.Name = "quantumLabel";
            this.quantumLabel.Size = new System.Drawing.Size(54, 24);
            this.quantumLabel.TabIndex = 14;
            this.quantumLabel.Text = "1000";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(402, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 37);
            this.button4.TabIndex = 15;
            this.button4.Text = "Generate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessId,
            this.TicketsCount,
            this.ProcessState,
            this.TimeLeft});
            this.dataGridView2.Location = new System.Drawing.Point(738, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(346, 388);
            this.dataGridView2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(834, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lottery planning";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.ticketCountTextBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.newProcessLottery);
            this.panel2.Location = new System.Drawing.Point(738, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 113);
            this.panel2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "WorkTime:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(17, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Push process";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // newProcessLottery
            // 
            this.newProcessLottery.Location = new System.Drawing.Point(155, 14);
            this.newProcessLottery.Name = "newProcessLottery";
            this.newProcessLottery.Size = new System.Drawing.Size(100, 20);
            this.newProcessLottery.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(945, 459);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 36);
            this.button6.TabIndex = 19;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(738, 459);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 36);
            this.button7.TabIndex = 18;
            this.button7.Text = "Start";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(1118, 588);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 37);
            this.button8.TabIndex = 29;
            this.button8.Text = "Generate";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // QuantumLottery
            // 
            this.QuantumLottery.AutoSize = true;
            this.QuantumLottery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantumLottery.Location = new System.Drawing.Point(1285, 375);
            this.QuantumLottery.Name = "QuantumLottery";
            this.QuantumLottery.Size = new System.Drawing.Size(54, 24);
            this.QuantumLottery.TabIndex = 28;
            this.QuantumLottery.Text = "1000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1118, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Quantum: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1118, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Choose the quantum:";
            // 
            // QuantumTextBoxLottery
            // 
            this.QuantumTextBoxLottery.Location = new System.Drawing.Point(1121, 172);
            this.QuantumTextBoxLottery.Name = "QuantumTextBoxLottery";
            this.QuantumTextBoxLottery.Size = new System.Drawing.Size(100, 20);
            this.QuantumTextBoxLottery.TabIndex = 25;
            this.QuantumTextBoxLottery.Text = "1000";
            this.QuantumTextBoxLottery.TextChanged += new System.EventHandler(this.QuantumTextBoxLottery_TextChanged);
            // 
            // processCountLottery
            // 
            this.processCountLottery.AutoSize = true;
            this.processCountLottery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processCountLottery.Location = new System.Drawing.Point(1285, 335);
            this.processCountLottery.Name = "processCountLottery";
            this.processCountLottery.Size = new System.Drawing.Size(21, 24);
            this.processCountLottery.TabIndex = 24;
            this.processCountLottery.Text = "4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1118, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "Process count: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(1118, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(237, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Choose number of processes:";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1118, 79);
            this.trackBar2.Minimum = 2;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(237, 45);
            this.trackBar2.TabIndex = 21;
            this.trackBar2.Value = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1118, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 66);
            this.label9.TabIndex = 30;
            this.label9.Text = "Choose the max count of lottery tickets for 1 process:";
            // 
            // ticketsCountTextBox
            // 
            this.ticketsCountTextBox.Location = new System.Drawing.Point(1121, 280);
            this.ticketsCountTextBox.Name = "ticketsCountTextBox";
            this.ticketsCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketsCountTextBox.TabIndex = 31;
            this.ticketsCountTextBox.Text = "10";
            this.ticketsCountTextBox.TextChanged += new System.EventHandler(this.ticketsCountTextBox_TextChanged);
            // 
            // TicketsCountLabel
            // 
            this.TicketsCountLabel.AutoSize = true;
            this.TicketsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketsCountLabel.Location = new System.Drawing.Point(1285, 423);
            this.TicketsCountLabel.Name = "TicketsCountLabel";
            this.TicketsCountLabel.Size = new System.Drawing.Size(32, 24);
            this.TicketsCountLabel.TabIndex = 33;
            this.TicketsCountLabel.Text = "10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(1118, 427);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 18);
            this.label15.TabIndex = 32;
            this.label15.Text = "Lottery tickets max: ";
            // 
            // Process
            // 
            this.Process.HeaderText = "Process";
            this.Process.Name = "Process";
            // 
            // WorkTime
            // 
            this.WorkTime.HeaderText = "WorkTime";
            this.WorkTime.Name = "WorkTime";
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            // 
            // ProcessId
            // 
            this.ProcessId.HeaderText = "ProcessId";
            this.ProcessId.Name = "ProcessId";
            // 
            // TicketsCount
            // 
            this.TicketsCount.HeaderText = "Tickets";
            this.TicketsCount.Name = "TicketsCount";
            // 
            // ProcessState
            // 
            this.ProcessState.HeaderText = "ProcessState";
            this.ProcessState.Name = "ProcessState";
            // 
            // TimeLeft
            // 
            this.TimeLeft.HeaderText = "Time Left";
            this.TimeLeft.Name = "TimeLeft";
            // 
            // happyTicketLabel
            // 
            this.happyTicketLabel.AutoSize = true;
            this.happyTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.happyTicketLabel.ForeColor = System.Drawing.Color.Blue;
            this.happyTicketLabel.Location = new System.Drawing.Point(1147, 467);
            this.happyTicketLabel.Name = "happyTicketLabel";
            this.happyTicketLabel.Size = new System.Drawing.Size(0, 108);
            this.happyTicketLabel.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(14, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tickets Count:";
            // 
            // ticketCountTextBox
            // 
            this.ticketCountTextBox.Location = new System.Drawing.Point(155, 40);
            this.ticketCountTextBox.Name = "ticketCountTextBox";
            this.ticketCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketCountTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 646);
            this.Controls.Add(this.happyTicketLabel);
            this.Controls.Add(this.TicketsCountLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ticketsCountTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.QuantumLottery);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.QuantumTextBoxLottery);
            this.Controls.Add(this.processCountLottery);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.quantumLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantumTextBox);
            this.Controls.Add(this.processCountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox newProcessTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label processCountLabel;
        private System.Windows.Forms.TextBox quantumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label quantumLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox newProcessLottery;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label QuantumLottery;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox QuantumTextBoxLottery;
        private System.Windows.Forms.Label processCountLottery;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ticketsCountTextBox;
        private System.Windows.Forms.Label TicketsCountLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessState;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLeft;
        private System.Windows.Forms.Label happyTicketLabel;
        private System.Windows.Forms.TextBox ticketCountTextBox;
        private System.Windows.Forms.Label label12;
    }
}

