using System;

public class JournalPrompts 
{
    private string[] _prompts = {
        "When did you wake up today?",
        "What did you eat for breakfast?",
        "Name a song you listened to today.",
        "Name a game you played today (video game, board game, sport, etc.)",
        "What kind of physical excersize did you do today?",
        "Write about a conversation you had today.",
        "Write about something you learned today.",
    };

    public string GeneratePrompt() {
        int index = new Random().Next(0, _prompts.Length);
        return _prompts[index];
    }
}

