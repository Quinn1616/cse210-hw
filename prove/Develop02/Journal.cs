
using Microsoft.VisualBasic;

public class Journal {

    //public string Name { get; set; }
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void DisplayJournal() {
        foreach (var entry in Entries) {
            Console.WriteLine($"\n{entry.EntryDate} - {entry.Prompt} \n{entry.UserResponse}\n");
        }
    }
    }
        
    

