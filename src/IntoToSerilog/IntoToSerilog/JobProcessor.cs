using System;
using System.Collections.Generic;
using System.Threading;
using IntoToSerilog.Models;
using Serilog;

namespace IntoToSerilog
{
    public static class JobProcessor
    {
        public static void Process(IEnumerable<Job> jobs)
        {
            foreach (var job in jobs)
            {
                Log.Logger.Information($"Starting to process job {job.Id} - {job.Name}");
                Thread.Sleep(1000);
                Console.WriteLine(job.ToString());
                Log.Logger.Information($"Finished processing job {job.Id} - {job.Name}");
            }
        }
    }
}
