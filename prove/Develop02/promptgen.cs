//prompt generator
using System;
using System.Collections.Generic;

public class new_prompt
{
    List<string> prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?",
        "What are some goals you successfully achieved today?"
    };
    int index = new Random.Next(prompts.count);
}   