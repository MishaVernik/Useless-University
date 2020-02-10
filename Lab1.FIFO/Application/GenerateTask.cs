using Lab1.FIFO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1.FIFO.Application
{
    public class GenerateTask
    {
        private readonly Random random;
        public int probability { get; set; }
        private int minComplexity = 10;
        private int maxComplexity = 100;
        public int taskComplexity { get; set; }        
        public GenerateTask()
        {
            random = new Random();
            probability = random.Next(1, 101);
            taskComplexity = random.Next(minComplexity, maxComplexity + 1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="delta">Can be from 0.0 to 10.0</param>
        public GenerateTask(float delta)
        {             
            random = new Random();
            probability = Convert.ToInt32(delta * 10);
        }

        public List<int> GetProcessors(int numberOfProcessors)
        {
            int length = random.Next(1, numberOfProcessors + 1);
            var result = GenerateSequenceOfProcessors.Combine(numberOfProcessors, length);
            return result[random.Next(0, result.Count)];            
        }

        public List<int> GetProcessors(int numberOfProcessors, List<int> availableProcessors)
        {
            int length = random.Next(1, numberOfProcessors + 1);
            var result = GenerateSequenceOfProcessors.Combine(numberOfProcessors, length, availableProcessors);
            return result[random.Next(0, result.Count)];
        }
        public Pair<bool, double> CanAppear()
        {
            int rnd = random.Next(1, 101);
            if (probability != 0)
            {
                return new Pair<bool, double>(rnd <= probability, probability);
            }
            return new Pair<bool, double> ( false, 0.0 );
        }
    }
}
