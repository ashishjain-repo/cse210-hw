using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;


public class PromptGenerator
{
    private string[] PromptListString;
    private List<string> PromptList = new List<string>();
   public PromptGenerator(List<string> PromptListTemp)
    {
        PromptList = PromptListTemp;
        PromptList.Add("Reflect on a moment that challenged your perspective today.");
        PromptList.Add("Recall a small act of kindness you witnessed or participated in today.");
        PromptList.Add("Describe a new skill or piece of knowledge you acquired today.");
        PromptList.Add("Share a moment from today that made you laugh or smile.");
        PromptList.Add("Consider a decision you made today and its impact on your day.");
        
    }
        Random Rand = new Random();

        private int RandomNumberGen()
        {
            int RandomNumber = Rand.Next(1,6);
            return RandomNumber;
        }
        public string uniquePromptGenerator()
        {

        }
     
        
}
/*
Reflect on a moment that challenged your perspective today.
Recall a small act of kindness you witnessed or participated in today.
Describe a new skill or piece of knowledge you acquired today.
Share a moment from today that made you laugh or smile.
Consider a decision you made today and its impact on your day.
*/