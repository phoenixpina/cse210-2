using System;


class Program
{
    static void Main(string[] args)
    {
        bool menu = true;
        string userChoice = "";
        Journal newJournal = new Journal();


        while(menu == true)
        {
            Console.WriteLine("This is your journal app. Type an option.");
            Console.WriteLine("1. Write \n2. Display \n3. Save \n4. Load \n5. Quit");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1": //Write a journal entry
                {
                    JournalPrompts promptsGenerator = new JournalPrompts();
                    string prompt = promptsGenerator.GeneratePrompt();
                    Console.WriteLine(prompt);
                    string userInput = Console.ReadLine();

                    JournalEntry userEntry = new JournalEntry();
                    userEntry.updateEntry(userInput);
                    userEntry.updatePrompt(prompt);
                    userEntry.updateDate(DateTime.Now.ToString());
                    //newJournal.addToList(userEntry);
                    newJournal.entries.Add(userEntry);
                    break;
                }
                case "2": //Display
                {
                    Console.WriteLine($"{newJournal.entries.Count()}");
                    foreach (JournalEntry entry in newJournal.entries)
                    {
                        Console.WriteLine($"Date: {entry.date} - Prompt: {entry.prompt}: {entry.entry}");
                    }
                    break;
                }
                case "3": //Save
                {
                    Console.WriteLine("Where do you want to save the file? ");
                    string userFile = Console.ReadLine();
                    SaveAndLoad entrySave = new SaveAndLoad();
                    entrySave.SaveEntry(newJournal.entries, userFile);
                    break;
                }
                case "4": //Load
                {
                    Console.WriteLine("What is your filename?");
                    string userFilename = Console.ReadLine();
                    SaveAndLoad entryLoad = new SaveAndLoad();
                    entryLoad.LoadEntry(userFilename);
                    break;
                }
                case "5": //Quit
                {
                    Console.WriteLine("Farewell.");
                    menu = false;
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid option.");
                    break;
                }
            }

        }
    }
}


//the below were for testing if the classes worked


       // JournalPrompts promptsGenerator = new JournalPrompts();
       // Console.WriteLine(promptsGenerator.GeneratePrompt());

    //    JournalEntry entry = new JournalEntry();
    //    entry.updateEntry("yeah");
    //    entry.updateDate("now");
    //    entry.updatePrompt("no");

    //    entry.Display();



    // JournalPrompts journalPrompts = new JournalPrompts();
    // Journal journal = new Journal(journalPrompts);
    // journal.addEntry();