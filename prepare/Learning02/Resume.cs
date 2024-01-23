public class Resume {
    public string _name;

    public List<Job> _jobs = new List<Job>(); //Job here is data type (the class)
    //you could also just put new(). But, you need to learn.

    public void Display() {
        foreach (Job job in _jobs) {  //second job is a newly declared variable. 
        //Every time the loop goes, a new variable instance is created.
            job.Display();
        }
    }
}