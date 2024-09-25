/* 
Class: Job
Attributes:
_companyName: string
_jobTitle: string
_startYear: int
_endYear: int
_yearlySalary: int

*/
public class Job
{
    public string _companyName = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public string DisplayJobDetails(string _jobTitle, string _companyName, int _startYear, int _endYear)
    {
        return Job.DisplayJobDetails($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}