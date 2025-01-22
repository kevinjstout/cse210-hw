using System;

class Program
{
    public class Job
    {
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
            }
    }

    public class Resume
    {
        public string _name;

        public List<Job> _jobs = new List<Job>();

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs: ");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }

    }

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Example_job_fjdskla";
        job1._company = "Bob the Builder Construction";
        job1._startYear = 1776;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Top Joe";
        job2._company = "Joe Mama Industries";
        job2._startYear = 4;
        job2._endYear = 1;

    
        Resume resume1 = new Resume();
        resume1._name = "Johovenny";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();


    }
    
}