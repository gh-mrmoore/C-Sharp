using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dictionaries!");

            Dictionary<string, string> thisDictionary = new Dictionary<string, string>();

            thisDictionary.Add("New York", "NY");
            thisDictionary.Add("Kansas City", "KS");
            thisDictionary.Add("Columbia", "MO");
            thisDictionary.Add("Las Vegas", "NV");

            foreach(KeyValuePair<string, string> place in thisDictionary)
            {
                Console.WriteLine(place.Key + " | " + place.Value);
            }

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::");

            thisDictionary.Remove("Columbia");
            foreach (KeyValuePair<string, string> place in thisDictionary)
            {
                Console.WriteLine(place.Key + " | " + place.Value);
            }


        }
    }
}
