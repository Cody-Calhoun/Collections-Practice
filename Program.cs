using System;
using System.Collections.Generic;


namespace collectionPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            // Arrays:
            int[] numArray;
            numArray = new int[] {0,1,2,3,4,5,6,7,8,9};
            foreach (int num in numArray)
            System.Console.WriteLine($"My favorite number is {num}");

            string[] someNames;
            someNames = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            // foreach (string name in someNames)
            System.Console.WriteLine($"My name is {name}");

            bool[] yesNo = new bool[10];
            for (int i = 0; i < yesNo.Length; i+= 2){
                yesNo[i] = true;
            }
            foreach (bool val in yesNo){
                System.Console.WriteLine(val);
            }

            // Lists
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Coffee");
            flavors.Add("Mint Chip");
            System.Console.WriteLine(flavors.Count);
            System.Console.WriteLine(flavors[2]);
            flavors.Remove("Strawberry");
            System.Console.WriteLine(flavors.Count);

            // Dictionaries

            Dictionary<string, string> profile = new Dictionary<string, string>();
            profile.Add("Tim", "Chocolate");
            profile.Add("Nikki", "Mint Chip");
            profile.Add("Martin", "Vanilla");
            profile.Add("Sara", "Coffee");

            foreach (KeyValuePair<string, string> entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }
    }
}
