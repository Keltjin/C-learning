using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "ArrowHead Studios";
        job1._job_title = "Software Enginner";
        job1._start_year = 2022;
        job1._end_year = 2024;

        Job job2 = new Job();
        job2._company = "Mojang";
        job2._job_title = "Front-End Developer";
        job2._start_year = 2020;
        job2._end_year = 2022;

        Resume myResume = new Resume();
        myResume._job.Add(job1);
        myResume._job.Add(job2);

        myResume.DisplayResume();
    }
}