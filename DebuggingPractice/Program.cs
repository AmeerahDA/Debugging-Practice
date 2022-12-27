using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        // Challenge 1
        //Cannot implicitly convert type 'string' to 'bool'
        bool amProgrammer = true;
        //Cannot implicitly convert type 'double' to 'int'
        int Age = Convert.ToInt32(27.9);
        List<string> Names = new List<string>();
        //Cannot implicitly convert type 'string' to 'System.Collections.Generic.List<string>'
        Names.Add("Monica");
        Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
        MyDictionary.Add("Hello", "0");
        //cannot convert from 'int' to 'string'
        MyDictionary.Add("Hi there", "0");
        // This is a tricky one! Hint: look up what a char is in C#
        //Too many characters in character literal
        string MyName = "MyName";
        Console.WriteLine(amProgrammer + " " + MyName);
        // Challenge 2
        List<int> Numbers = new List<int>() { 2, 3, 6, 7, 1, 5 };
        //Index was out of range.
        for (int i = Numbers.Count -1; i >= 0; i--)
        {
            Console.WriteLine(Numbers[i]);
        }
        // Challenge 3
        //Index was out of range
        List<int> MoreNumbers = new List<int>() { 12, 7, 10, -3, 9 };
        foreach (int i in MoreNumbers)
        {
            Console.WriteLine(i);
        }
        // Challenge 4
        //use for loop with variable i as index
        List<int> EvenMoreNumbers = new List<int> { 3, 6, 9, 12, 14 };
        /* foreach (int num in EvenMoreNumbers)
         {
             if (num % 3 == 0)
             {
                 num = 0;
             }
         }*/
        for (int i = 0; i < EvenMoreNumbers.Count; i++)
        {
            if (EvenMoreNumbers[i] % 3 == 0)
            {
                EvenMoreNumbers[i] = 0;
            }
            Console.Write(EvenMoreNumbers[i] + " ");
        }
        // Challenge 5
        // What can we learn from this error message?
        //cannot be assigned to -- it is read only

        //string MyString = "superduberawesome";
        //MyString[7] = "p";
        
        // Challenge 6
        // Hint: some bugs don't come with error messages
        Random rand = new Random();
        int randomNum = rand.Next(12);
        //the condition 
        if (randomNum <= 12)
        {
            Console.WriteLine("Hello");
        }
    }
}