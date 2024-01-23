using System.Security.AccessControl;

public class Job {
        public string _company; //public is required for usage by other programs- namely, the main "Program.cs"

        public string _jobTitle;

        public int _startYear;

        public int _endYear;

        public void Display() {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
}


// public Job(string companyName, string title, int start, int end) {
//  company = companyName;
//  jobTitle = title; ect.

// then make the above variables private (and remove underscores in front)
// then in the main program:
//  Job job1 = new Job("Del Taco", "Manager", 1706, 2020);

//this is the better looking way to code this
//teacher will put his code somewhere. probably on Teams