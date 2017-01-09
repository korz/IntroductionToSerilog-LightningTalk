using System;
using Serilog;
using Serilog.Events;

namespace IntoToSerilog
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.ColoredConsole()
                .WriteTo.RollingFile("log.txt", LogEventLevel.Verbose)
                .CreateLogger();

            Log.Logger.Information("Starting application");
            var jobs = FakeJobRepository.GetJobs();
            Log.Logger.Information("Got jobs from the database");

            JobProcessor.Process(jobs);
            Log.Logger.Information("Finished processing all jos");

            Console.ReadLine();
        }
    }
}
