public class Job 
{
    public string _company;
    public string _job_title;
    public int _start_year;
    public int _end_year;

     public Job()
    {

    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_job_title} ({_company}) {_start_year}-{_end_year}");
    }
}