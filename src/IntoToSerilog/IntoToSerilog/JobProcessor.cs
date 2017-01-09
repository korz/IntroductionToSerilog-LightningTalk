using System;
using System.Collections.Generic;
using IntoToSerilog.Models;

namespace IntoToSerilog
{
    public static class JobProcessor
    {
        public static void Process(IEnumerable<Job> jobs)
        {
            foreach (var job in jobs)
            {
                Process(job);
            }
        }

        public static void Process(Job job)
        {
            Console.WriteLine(job.ToString());
        }
    }
}
