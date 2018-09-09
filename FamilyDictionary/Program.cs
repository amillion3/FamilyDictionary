using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // type, which contains a type myFam = new instance of type, which contains a type
            // type Dictionary of string and nested dictionary of string & string named myFam
            // Dictionary<string, Dictionary<string, string>> myFam = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, Dictionary<string, string>> myFam = new Dictionary<string, Dictionary<string, string>>();

            myFam.Add("brother", new Dictionary<string, string>(){
                { "name", "Steve"},
                { "age", "19" }
            });
            myFam.Add("sister", new Dictionary<string, string>() {
                { "name", "Jenny"},
                { "age", "21" }
            });

            foreach(var i in myFam)
            {
                Console.WriteLine($"{i.Value["name"]} is my {i.Key} and is {i.Value["age"]} years old");
            }

            Console.ReadLine();
        }
    }
}
