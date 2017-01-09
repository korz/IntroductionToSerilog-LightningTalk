﻿namespace IntoToSerilog.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
