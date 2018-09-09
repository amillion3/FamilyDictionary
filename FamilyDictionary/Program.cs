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
            Dictionary<string, Dictionary<string, string>> myFam = new Dictionary<string, Dictionary<string, string>>();

            myFam.Add("brother", new Dictionary<string, string>(){
                { "name", "Steve"},
                { "age", "19" }
            });
            myFam.Add("sister", new Dictionary<string, string>() {
                { "name", "Jenny"},
                { "age", "21" }
            });
            // myFamily.Add("sister", new Dictionary<string, string>(){
            //    {"name", "Krista"},
            //    {"age", "42"}
            // });
            //  Next, iterate over each item in myFamily and produce the following output.

            // Krista is my sister and is 42 years old
        }
    }
}
