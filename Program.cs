using System;

namespace PatikaStringMetotlar;

class Solution
{
    static void Main(string[] args)
    {
        string var1 = "Geçmişi değiştiremezsin ama geçmişin seni değiştirebilir";
        string var2 = "Bereket hayatınızdan çekilirse, çuval dolusu paranızla aç gezersiniz";

        //Length 
        System.Console.WriteLine(var1.Length);

        //ToUpper, ToLower
        System.Console.WriteLine(var1.ToUpper());
        System.Console.WriteLine(var2.ToLower());

        //Concat
        System.Console.WriteLine(string.Concat(var1,", Bunu unutma"));

        //Compare, CompareTo
        System.Console.WriteLine(var2.CompareTo(var1));

        //Contains
        System.Console.WriteLine(var1.Contains(var2));
        System.Console.WriteLine(var2.EndsWith("gezersiniz"));

        //IndexOf
        System.Console.WriteLine(var2.IndexOf("çuval"));

        //Insert
        System.Console.WriteLine(var2.Insert(0,"Unutma: "));

        //Remove
        System.Console.WriteLine(var1.Remove(10));
        System.Console.WriteLine(var1.Remove(0,5));

        //Replace
        System.Console.WriteLine(var1.Replace("ama","lakin"));

        //Split
        System.Console.WriteLine(var1.Split(' ')[0]);

        //Substring
        System.Console.WriteLine(var2.Substring(0,5));
    }
}
