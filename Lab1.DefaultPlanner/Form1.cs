using Lab1.FIFO.Application;
using Lab1.FIFO.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.DefaultPlanner
{
    public partial class Form1 : Form
    {
        public int TOTAL_TASKS { get; set; }
        private readonly int numberOfProcessors = 5;
        private List<Processor> processors;
        private List<int> availableProcessors;
        private GenerateTask generateTask;
        private int GENERAL_TIME = 10;
        public int GENERAL_PROBABILITY { get; set; }
        public int GENERAL_COMPLEXITY { get; set; }
        public Memory<ListView> listViews { get; set; }
        public Memory<TextBox> textBoxes { get; set; }
        public int PLANNER_PROCESSOR_INDEX { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            availableProcessors = new List<int>();
            listViews = new Memory<ListView>(new ListView[] { listView1, listView2, listView3, listView4, listView5 });
            textBoxes = new Memory<TextBox>(new TextBox[] { textBoxProcessor1, textBoxProcessor2, textBoxProcessor3, textBoxProcessor4, textBoxProcessor5 });

            generateTask = new GenerateTask();
            processors = new List<Processor>();
            for (int i = 0; i < numberOfProcessors; i++)
            {
                processors.Add(new Processor());
                await Task.Delay(10);
            }
            #region Processor's perfomance manual
            try
            {
                processors[0].perfomance = Convert.ToInt32(textBoxProcessor1.Text);
            }
            catch (Exception ex)
            {

                //throw ex;
            }
            try
            {
                processors[1].perfomance = Convert.ToInt32(textBoxProcessor2.Text);
            }
            catch (Exception ex)
            {

                //throw ex;
            }

            try
            {
                processors[2].perfomance = Convert.ToInt32(textBoxProcessor3.Text);
            }
            catch (Exception ex)
            {

                //throw ex;
            }
            try
            {
                processors[3].perfomance = Convert.ToInt32(textBoxProcessor4.Text);
            }
            catch (Exception ex)
            {

                //throw ex;
            }
            try
            {
                processors[4].perfomance = Convert.ToInt32(textBoxProcessor5.Text);
            }
            catch (Exception ex)
            {

                //throw ex;
            }
            TextBox[] array = textBoxes.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                TextBox item = (TextBox)array[i];
                item.Text = processors[i].perfomance.ToString();
            }
            #endregion
            #region Initial Settings
            try
            {
                generateTask.probability = Convert.ToInt32(Convert.ToDouble(textBoxProbability.Text) * 100);
                GENERAL_PROBABILITY = generateTask.probability;
            }
            catch (Exception ex)
            {

                // throw;
            }

            try
            {
                generateTask.taskComplexity = Convert.ToInt32(textBoxComplexity.Text);
                GENERAL_COMPLEXITY = generateTask.taskComplexity;
            }
            catch (Exception ex)
            {

                // throw;
            }
            #endregion

            double minPerfomance = processors.Min(b => b.perfomance);
            PLANNER_PROCESSOR_INDEX = processors.FindIndex(b => b.perfomance == minPerfomance);
            listViews.ToArray()[PLANNER_PROCESSOR_INDEX].Items.Add("Planner");
            // Remove processor;
            // processors.RemoveAt(PLANNER_PROCESSOR_INDEX);
            InitializeAvailableProcessors();

            timer1.Start();
            timer1000.Start();
        }

        private void InitializeAvailableProcessors()
        {
            availableProcessors = new List<int>();
            for (int i = 0; i < numberOfProcessors; i++)
                if (i != PLANNER_PROCESSOR_INDEX)
                    availableProcessors.Add(i);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (var item in listViews.ToArray())
            {
                item.Items.Clear();
            }
            TOTAL_TASKS = 0;
            listView6.Items.Clear();
            
            // availableProcessors.Clear();
            labelTime.Text = "10";
            GENERAL_TIME = 10;
            GENERAL_PROBABILITY = -1;
            GENERAL_COMPLEXITY = -1;
            timer1.Stop();
            timer1000.Stop();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            SystemStatistics();
            timer1.Stop();
            timer1000.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfProcessors; i++)
            {
                processors[i].MillisecondRemove();
            }

            generateTask = new GenerateTask();
            if (GENERAL_PROBABILITY > 0)
                generateTask.probability = GENERAL_PROBABILITY;
            if (GENERAL_COMPLEXITY > 0)
                generateTask.taskComplexity = GENERAL_COMPLEXITY;

            var processorsInUse = generateTask.GetProcessors(availableProcessors.Count, availableProcessors);
            var minInd = processorsInUse[0];
            double load = (double)Int32.MaxValue;
            double tmp = 0;
            GetMinLoadedProcessor(ref minInd, ref load, ref tmp, processorsInUse);

            var currentProcessor = minInd;
            Pair<bool, double> pair = generateTask.CanAppear();

            for (int i = 0; i < processorsInUse.Count; i++) processorsInUse[i]++;

            if (pair.First)
            {
                TOTAL_TASKS++;
                processors[currentProcessor].AddTask(generateTask.taskComplexity);

                //    if (processorsInUse.Count > 1)
                //        processorsInUse.RemoveAt(processorsInUse.Count - 1);
                ListViewItem listView = new ListViewItem(
                        new string[]{ string.Join(" ", processorsInUse),
                        generateTask.taskComplexity.ToString(),
                        processors[currentProcessor].queue.ToString()}
                    );
                // shitty construction 
                listViews.ToArray()[currentProcessor].Items.Add(listView);
            }

            ListViewItem lstRes = new ListViewItem(
                   new string[]{
                           (pair.Second / 100.0).ToString(),
                           pair.First.ToString(),
                           string.Join(" ", processorsInUse),
                           generateTask.taskComplexity.ToString(),
                           processors[currentProcessor].queue.ToString()}
               );
            listView6.Items.Add(lstRes);
        }

        private void GetMinLoadedProcessor(ref int minInd, ref double load, ref double tmp, List<int> processorsInUse)
        {
            foreach (var indx in processorsInUse)
            {
                tmp = processors[indx].Loaded(generateTask.taskComplexity);
                if (tmp <= load)
                {
                    minInd = indx;
                    load = tmp;
                }
            }
        }

        private void timer1000_Tick(object sender, EventArgs e)
        {
            GENERAL_TIME--;
            labelTime.Text = GENERAL_TIME.ToString();
            if (GENERAL_TIME == 0)
            {
                SystemStatistics();

                labelTime.Text = listView6.Items.Count.ToString();
                timer1.Stop();
                timer1000.Stop();
            }
        }

        private void SystemStatistics()
        {
            if (TOTAL_TASKS == 0) return;
            int numberOfColmpletedTasks = 0;
            int numberOfTotalOperations = 0;
            double ECE = 0.0;


            int maxEfficienty = 0;

            foreach (var processor in processors)
            {
                int tmp = processor.NumberOfCompletedTasks();
                numberOfColmpletedTasks += tmp;
                numberOfTotalOperations += tmp * processor.perfomance;
                maxEfficienty += processor.perfomance;
            }
            ECE = (double)numberOfTotalOperations / (double)(numberOfColmpletedTasks * maxEfficienty);
            ECE = (double)numberOfColmpletedTasks / (double)TOTAL_TASKS;
            labelCompletedTasks.Text = numberOfColmpletedTasks.ToString();
            labelTotalOperations.Text = numberOfTotalOperations.ToString();
            labelECE.Text = string.Format("{0:N6}", ECE);
            TOTAL_TASKS = 0;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            GENERAL_PROBABILITY = -1;
            GENERAL_COMPLEXITY = -1;
            generateTask = new GenerateTask();
            processors = new List<Processor>();
            for (int i = 0; i < numberOfProcessors; i++)
            {
                processors.Add(new Processor());
                await Task.Delay(10);
            }

        }
    }
}
