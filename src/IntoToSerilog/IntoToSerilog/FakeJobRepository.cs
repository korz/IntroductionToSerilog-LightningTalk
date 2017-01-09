using System.Collections.Generic;
using IntoToSerilog.Models;

namespace IntoToSerilog
{
    public static class FakeJobRepository
    {
        public static IEnumerable<Job> GetJobs()
        {
            yield return new Job {Id = 1, Name = "First Job"};
            yield return new Job {Id = 2, Name = "Second Job"};
            yield return new Job {Id = 3, Name = "Third Job"};
            yield return new Job {Id = 4, Name = "Fourth Job"};
            yield return new Job {Id = 5, Name = "Fifth Job"};
            yield return new Job {Id = 6, Name = "Sixth Job"};
            yield return new Job {Id = 7, Name = "Seventh Job"};
            yield return new Job {Id = 8, Name = "Eighth Job"};
            yield return new Job {Id = 9, Name = "Nineth Job"};
            yield return new Job {Id = 10, Name = "Tenth Job"};
        }
    }
}
