using System;

namespace IntoToSerilog
{
    class Program
    {
        static void Main(string[] args)
        {
            var jobs = FakeJobRepository.GetJobs();

            JobProcessor.Process(jobs);

            Console.ReadLine();
        }
    }
}
