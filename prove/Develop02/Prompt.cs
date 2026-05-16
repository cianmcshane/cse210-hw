using System;
using System.Collections.Generic;


public class Prompter

{

    public static string _cmPrompt()
    {
        List<string> cmPrompts;
        cmPrompts = new List<string>
        {
            "What was your favoite part of today?",
            "What was your lesast favoite part of today?",
            "What is one thing you would change about to day if you could go back in time?",
            "What is a goal you have for tommorow?",
            "What did you learn today?",
            "What are three things you did today?"
        };

        Random cmRandom = new Random();
        int cmRandomNumber = cmRandom.Next(cmPrompts.Count);
        
        return cmPrompts[cmRandomNumber];
    }
}