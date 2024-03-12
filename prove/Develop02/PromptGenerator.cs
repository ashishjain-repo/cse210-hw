using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;


public class PromptGenerator
{
    private List<string> _promptlist = new List<string>();
   public PromptGenerator()
    {
        _promptlist.Add("Reflect on a moment that challenged your perspective today.");
        _promptlist.Add("Recall a small act of kindness you witnessed or participated in today.");
        _promptlist.Add("Describe a new skill or piece of knowledge you acquired today.");
        _promptlist.Add("Share a moment from today that made you laugh or smile.");
        _promptlist.Add("Consider a decision you made today and its impact on your day.");   
    }
        Random Rand = new Random();

        private int RandomNumberGen()
        {   
            int RandomNumber = Rand.Next(0,5);
            return RandomNumber;
        }
        public string UniquePromptGenerator()
        {
            int TempRand = RandomNumberGen();
            string TempPrompt = _promptlist[TempRand];
            return TempPrompt;
        }
        
}
/*
Reflect on a moment that challenged your perspective today.
Recall a small act of kindness you witnessed or participated in today.
Describe a new skill or piece of knowledge you acquired today.
Share a moment from today that made you laugh or smile.
Consider a decision you made today and its impact on your day.
*/