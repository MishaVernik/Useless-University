using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.FIFO.Domain
{
    public class ProcessorModel
    {
        /// <summary>
        /// Number of operations per second.
        /// </summary>
        public int perfomance { get; set; }
        /// <summary>
        /// Unique ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// [Optional]
        /// The processor's name.
        /// </summary>
        public string name { get; set; }
    }
}
