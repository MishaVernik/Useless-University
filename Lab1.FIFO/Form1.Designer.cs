namespace Lab1.FIFO
{
    partial class FIFOForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProcessor5 = new System.Windows.Forms.TextBox();
            this.textBoxProcessor4 = new System.Windows.Forms.TextBox();
            this.textBoxProcessor3 = new System.Windows.Forms.TextBox();
            this.textBoxProcessor2 = new System.Windows.Forms.TextBox();
            this.textBoxProcessor1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComplexity = new System.Windows.Forms.TextBox();
            this.textBoxProbability = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxProcessors = new System.Windows.Forms.GroupBox();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Processors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Complexity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Queue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxTasks = new System.Windows.Forms.GroupBox();
            this.listView6 = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer1000 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelCompletedTasks = new System.Windows.Forms.Label();
            this.labelTotalOperations = new System.Windows.Forms.Label();
            this.labelECE = new System.Windows.Forms.Label();
            this.groupBoxControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxProcessors.SuspendLayout();
            this.groupBoxTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(17, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(82, 45);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(17, 82);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(82, 45);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.labelECE);
            this.groupBoxControl.Controls.Add(this.labelTotalOperations);
            this.groupBoxControl.Controls.Add(this.labelCompletedTasks);
            this.groupBoxControl.Controls.Add(this.label11);
            this.groupBoxControl.Controls.Add(this.label7);
            this.groupBoxControl.Controls.Add(this.label6);
            this.groupBoxControl.Controls.Add(this.labelTime);
            this.groupBoxControl.Controls.Add(this.label5);
            this.groupBoxControl.Controls.Add(this.groupBox2);
            this.groupBoxControl.Controls.Add(this.groupBox1);
            this.groupBoxControl.Controls.Add(this.buttonReset);
            this.groupBoxControl.Controls.Add(this.buttonStart);
            this.groupBoxControl.Controls.Add(this.buttonStop);
            this.groupBoxControl.Location = new System.Drawing.Point(12, 23);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(289, 625);
            this.groupBoxControl.TabIndex = 2;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Control";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(163, 98);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(19, 13);
            this.labelTime.TabIndex = 19;
            this.labelTime.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Time : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxProcessor5);
            this.groupBox2.Controls.Add(this.textBoxProcessor4);
            this.groupBox2.Controls.Add(this.textBoxProcessor3);
            this.groupBox2.Controls.Add(this.textBoxProcessor2);
            this.groupBox2.Controls.Add(this.textBoxProcessor1);
            this.groupBox2.Location = new System.Drawing.Point(17, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 172);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processors Perfomance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Processor 5:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Processor 4:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Processor 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Processor 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Processor 1:";
            // 
            // textBoxProcessor5
            // 
            this.textBoxProcessor5.Location = new System.Drawing.Point(85, 135);
            this.textBoxProcessor5.Name = "textBoxProcessor5";
            this.textBoxProcessor5.Size = new System.Drawing.Size(100, 20);
            this.textBoxProcessor5.TabIndex = 12;
            // 
            // textBoxProcessor4
            // 
            this.textBoxProcessor4.Location = new System.Drawing.Point(85, 109);
            this.textBoxProcessor4.Name = "textBoxProcessor4";
            this.textBoxProcessor4.Size = new System.Drawing.Size(100, 20);
            this.textBoxProcessor4.TabIndex = 11;
            // 
            // textBoxProcessor3
            // 
            this.textBoxProcessor3.Location = new System.Drawing.Point(85, 83);
            this.textBoxProcessor3.Name = "textBoxProcessor3";
            this.textBoxProcessor3.Size = new System.Drawing.Size(100, 20);
            this.textBoxProcessor3.TabIndex = 10;
            // 
            // textBoxProcessor2
            // 
            this.textBoxProcessor2.Location = new System.Drawing.Point(85, 57);
            this.textBoxProcessor2.Name = "textBoxProcessor2";
            this.textBoxProcessor2.Size = new System.Drawing.Size(100, 20);
            this.textBoxProcessor2.TabIndex = 9;
            // 
            // textBoxProcessor1
            // 
            this.textBoxProcessor1.Location = new System.Drawing.Point(85, 31);
            this.textBoxProcessor1.Name = "textBoxProcessor1";
            this.textBoxProcessor1.Size = new System.Drawing.Size(100, 20);
            this.textBoxProcessor1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxComplexity);
            this.groupBox1.Controls.Add(this.textBoxProbability);
            this.groupBox1.Location = new System.Drawing.Point(17, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Complexity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Probability:";
            // 
            // textBoxComplexity
            // 
            this.textBoxComplexity.Location = new System.Drawing.Point(85, 57);
            this.textBoxComplexity.Name = "textBoxComplexity";
            this.textBoxComplexity.Size = new System.Drawing.Size(100, 20);
            this.textBoxComplexity.TabIndex = 12;
            // 
            // textBoxProbability
            // 
            this.textBoxProbability.Location = new System.Drawing.Point(85, 31);
            this.textBoxProbability.Name = "textBoxProbability";
            this.textBoxProbability.Size = new System.Drawing.Size(100, 20);
            this.textBoxProbability.TabIndex = 11;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(120, 19);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(82, 45);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxProcessors
            // 
            this.groupBoxProcessors.Controls.Add(this.listView4);
            this.groupBoxProcessors.Controls.Add(this.listView5);
            this.groupBoxProcessors.Controls.Add(this.listView3);
            this.groupBoxProcessors.Controls.Add(this.listView2);
            this.groupBoxProcessors.Controls.Add(this.listView1);
            this.groupBoxProcessors.Location = new System.Drawing.Point(307, 23);
            this.groupBoxProcessors.Name = "groupBoxProcessors";
            this.groupBoxProcessors.Size = new System.Drawing.Size(742, 350);
            this.groupBoxProcessors.TabIndex = 3;
            this.groupBoxProcessors.TabStop = false;
            this.groupBoxProcessors.Text = "Processors";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(254, 187);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(199, 130);
            this.listView4.TabIndex = 4;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Processors";
            this.columnHeader7.Width = 68;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Complexity";
            this.columnHeader8.Width = 64;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Queue";
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(22, 187);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(199, 130);
            this.listView5.TabIndex = 3;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Processors";
            this.columnHeader10.Width = 68;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Complexity";
            this.columnHeader11.Width = 64;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Queue";
            // 
            // listView3
            // 
            this.listView3.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(490, 30);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(199, 130);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Processors";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Complexity";
            this.columnHeader5.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Queue";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(254, 30);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(199, 130);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Processors";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Complexity";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Queue";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Processors,
            this.Complexity,
            this.Queue});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(199, 130);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Processors
            // 
            this.Processors.Text = "Processors";
            this.Processors.Width = 68;
            // 
            // Complexity
            // 
            this.Complexity.Text = "Complexity";
            this.Complexity.Width = 64;
            // 
            // Queue
            // 
            this.Queue.Text = "Queue";
            // 
            // groupBoxTasks
            // 
            this.groupBoxTasks.Controls.Add(this.listView6);
            this.groupBoxTasks.Location = new System.Drawing.Point(307, 379);
            this.groupBoxTasks.Name = "groupBoxTasks";
            this.groupBoxTasks.Size = new System.Drawing.Size(742, 269);
            this.groupBoxTasks.TabIndex = 4;
            this.groupBoxTasks.TabStop = false;
            this.groupBoxTasks.Text = "Tasks";
            // 
            // listView6
            // 
            this.listView6.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listView6.HideSelection = false;
            this.listView6.HoverSelection = true;
            this.listView6.Location = new System.Drawing.Point(36, 31);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(674, 220);
            this.listView6.TabIndex = 5;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Probability";
            this.columnHeader13.Width = 75;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Exists";
            this.columnHeader14.Width = 58;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Processors";
            this.columnHeader15.Width = 106;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Complexity";
            this.columnHeader16.Width = 87;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1000
            // 
            this.timer1000.Interval = 1000;
            this.timer1000.Tick += new System.EventHandler(this.timer1000_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Completed tasks : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total operations : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "ECE :";
            // 
            // labelCompletedTasks
            // 
            this.labelCompletedTasks.AutoSize = true;
            this.labelCompletedTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompletedTasks.Location = new System.Drawing.Point(169, 473);
            this.labelCompletedTasks.Name = "labelCompletedTasks";
            this.labelCompletedTasks.Size = new System.Drawing.Size(18, 20);
            this.labelCompletedTasks.TabIndex = 24;
            this.labelCompletedTasks.Text = "0";
            // 
            // labelTotalOperations
            // 
            this.labelTotalOperations.AutoSize = true;
            this.labelTotalOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOperations.Location = new System.Drawing.Point(169, 500);
            this.labelTotalOperations.Name = "labelTotalOperations";
            this.labelTotalOperations.Size = new System.Drawing.Size(18, 20);
            this.labelTotalOperations.TabIndex = 25;
            this.labelTotalOperations.Text = "0";
            // 
            // labelECE
            // 
            this.labelECE.AutoSize = true;
            this.labelECE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelECE.Location = new System.Drawing.Point(169, 529);
            this.labelECE.Name = "labelECE";
            this.labelECE.Size = new System.Drawing.Size(18, 20);
            this.labelECE.TabIndex = 26;
            this.labelECE.Text = "0";
            // 
            // FIFOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 660);
            this.Controls.Add(this.groupBoxTasks);
            this.Controls.Add(this.groupBoxProcessors);
            this.Controls.Add(this.groupBoxControl);
            this.Name = "FIFOForm";
            this.Text = "FIFO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxProcessors.ResumeLayout(false);
            this.groupBoxTasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProcessor5;
        private System.Windows.Forms.TextBox textBoxProcessor4;
        private System.Windows.Forms.TextBox textBoxProcessor3;
        private System.Windows.Forms.TextBox textBoxProcessor2;
        private System.Windows.Forms.TextBox textBoxProcessor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxComplexity;
        private System.Windows.Forms.TextBox textBoxProbability;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxProcessors;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Processors;
        private System.Windows.Forms.ColumnHeader Complexity;
        private System.Windows.Forms.ColumnHeader Queue;
        private System.Windows.Forms.GroupBox groupBoxTasks;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Timer timer1000;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelECE;
        private System.Windows.Forms.Label labelTotalOperations;
        private System.Windows.Forms.Label labelCompletedTasks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

