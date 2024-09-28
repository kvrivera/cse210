/* 
Class: Job
Attributes:
_companyName: string
_jobTitle: string
_startYear: int
_endYear: int
_yearlySalary: int

*/
using System.Runtime.CompilerServices;

public class Job
{
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // create a method to display job details
    public void DisplayJobDetails() // needs no parameters, no returns
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}