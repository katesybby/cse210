using System;

public class PromptGenerator
{
   public string[] _prompts = new string[]
   {
        "What are you grateful for today?",
        "Describe a memorable moment from today.",
        "What is something you learned today?",
        "How did you help someone today?",
        "What are your goals for tomorrow?"
   };

   public string GetRandomPrompt()
   {
       Random random = new Random();
       int index = random.Next(_prompts.Length);
       return _prompts[index];
    }
 }
