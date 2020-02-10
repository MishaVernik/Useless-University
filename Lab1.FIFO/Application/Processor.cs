using Lab1.FIFO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.FIFO.Application
{
    public class Processor : ProcessorModel
    {        
        private readonly int minPerfomance = 1;
        private readonly int maxPerfomance = 10;
        private static int GLOBAL_ID = 1;
        private readonly Random random;
        public int timeToBePlanner { get; set; }
        public int timeToBeProcessor { get; set; }
        public GenerateProcessor generateProcessor;
        public List<int> tasks { get; set; }        
        public int queue{ get; set; }                
        public int cumulativeSum { get; set; }
        public Processor()
        {
            timeToBePlanner = 4;
            timeToBeProcessor = 20;
            random = new Random();
            this.perfomance = random.Next(minPerfomance, maxPerfomance + 1);
            this.id = ++GLOBAL_ID;
            this.name = Guid.NewGuid().ToString();            

            cumulativeSum = 0;
            queue = 0;
            tasks = new List<int>();
        }

        public void AddTask(int taskCapacity)
        {
            queue += taskCapacity;
            tasks.Add(taskCapacity);            
        }


        public double Loaded(int taskComplexity)
        {
            return (queue + taskComplexity) / (double)perfomance;
        }
        public void MillisecondRemove()
        {
            int tmp = queue;
            queue -= perfomance;
            if (queue < 0)
            {
                queue = 0;
                cumulativeSum += tmp;
            }
            else
                cumulativeSum += perfomance;                
        }

        public int NumberOfCompletedTasks()
        {
            int tmp = cumulativeSum;
            int number = 0;
            while (tasks.Count > 0 && tasks[0] < tmp)
            {
                tmp -= tasks[0];
                tasks.RemoveAt(0);
                number++;
            }

            return number;
        }
    }

}
