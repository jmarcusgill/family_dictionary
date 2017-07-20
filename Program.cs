using System;
using System.Collections.Generic;
using System.Linq;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Ann"},
                {"age", "27"}
            });

            myFamily.Add("Older-brother", new Dictionary<string, string>(){
                {"name", "Micah"},
                {"age", "30"}
            });

            myFamily.Add("Middle-brother", new Dictionary<string, string>(){
                {"name", "Matthew"},
                {"age", "28"}
            });

            myFamily.Add("father", new Dictionary<string, string>(){
                {"name", "Maury"},
                {"age", "57"}
            });

            myFamily.Add("mother", new Dictionary<string, string>(){
                {"name", "Nan"},
                {"age", "56"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> sibling in myFamily)
            {
                Console.WriteLine($"{sibling.Value["name"]} is my {sibling.Key} and is {sibling.Value["age"]} years old ");
            }
            
        }
    }
}
