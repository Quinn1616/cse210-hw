public class Resume {

    public string Name { get; set; }

    //Initializes the list
    public List<Job> Jobs = new List<Job>();

    //public List<Job> Jobs { get; set; }  (Doesn't work)

    public Resume() {

    }

    public void Display() {
        Console.WriteLine($"Name: {Name}");
        Console.Write("Jobs: ");
        
        foreach (Job job in Jobs) {
            job.Display();
        }
    }
}