using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        private string v;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public Job(string v)
        {
            this.v = v;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override string ToString()
        {
            string output;
            if (Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                output = "\nOOPS! This job does not seem to exist.\n";
            }
            else
            {
                string notAvailable = "Data not available";
                output = "\n" +
                        $"ID: {Id}\n" +
                        $"Name: {(String.IsNullOrEmpty(Name.ToString()) ? notAvailable : Name.ToString())}\n" +
                        $"Employer: {(String.IsNullOrEmpty(EmployerName.ToString()) ? notAvailable : EmployerName.ToString())}\n" +
                        $"Location: {(String.IsNullOrEmpty(EmployerLocation.ToString()) ? notAvailable : EmployerLocation.ToString())}\n" +
                        $"Position Type: {(String.IsNullOrEmpty(JobType.ToString()) ? notAvailable : JobType.ToString())}\n" +
                        $"Core Competency: {(String.IsNullOrEmpty(JobCoreCompetency.ToString()) ? notAvailable : JobCoreCompetency.ToString())}\n" +
                         "\n";
            }
            return output;
        }
    }
}
