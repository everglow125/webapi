using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class ProcessState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalProcessorTimeInMillis { get; set; }

        public ProcessState() { }
        public ProcessState(Process proc)
        {
            Id = proc.Id;
            Name = proc.ProcessName;
            TotalProcessorTimeInMillis = proc.TotalProcessorTime.TotalMilliseconds;
        }

    }
    public class ProcessCollectionState
    {
        public IEnumerable<ProcessState> Processes { get; set; }
    }
}