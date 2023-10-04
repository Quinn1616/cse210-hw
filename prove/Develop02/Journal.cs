
using Microsoft.VisualBasic;

public class Journal {
    //prompt list
    public List<string> promptList = new List<string>() {"Test1", "Test2", "Test3"};

    //entries list
    public List<string> entryList = new List<string>();

    //display prompt
    //gets user input from entry class
    //receives prompt from entry class

    static void DisplayPrompt(List<string> promptList) {
        Console.WriteLine(promptList[0]);
    }


    static string WriteJournalToEntriesList() {
        return null;
    }
}