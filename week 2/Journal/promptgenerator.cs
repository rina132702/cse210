
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "Who made a positive impact on my day?",
        "What is something I am grateful for today?",
        "What was the biggest challenge I faced today?",
        "How did I see the hand of the Lord in my life today?",
        "What is one thing I learned today?",
        "What made me smile today?",
        "What is something I want to improve tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
