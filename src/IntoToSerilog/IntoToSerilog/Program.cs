using System;
using Serilog;

namespace IntoToSerilog
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();

            Log.Logger = logger;

            Log.Logger.Information("Starting application");
            var jobs = FakeJobRepository.GetJobs();
            Log.Logger.Information("Got jobs from the database");

            JobProcessor.Process(jobs);
            Log.Logger.Information("Finished processing all jos");

            Console.ReadLine();
        }
    }
}
