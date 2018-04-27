using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numArray = {0,1,2,3,4,5,6,7,8,9}; 
            string[] myNames = {"Tim", "Martin", "Nikki", "Sarah"};
            bool[] myBools = {true, false, true, false, true, false, true, false, true, false};
            int[] multArray = {1,2,3,4,5,6,7,8,9,10}; 
            int[,] multiplicationTable = new int[10,10];
            for(int i = 1; i < 11; i++)
            {
                for(int j = i-1; j < 10; j++)
                {
                    for(int k = 0; k < 10; k++)
                    {
                        multiplicationTable[j,k] = multArray[k] * i;
                    }
                }
            }
        
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("PB");
            flavors.Add("Toffee");
            Console.WriteLine("# of flavs: " + flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine("# of flavs now: " + flavors.Count);

            Dictionary<string,string> profile = new Dictionary<string,string>();
            Random rand = new Random();
            int rando = rand.Next(0, myNames.Length);
            foreach (string name in myNames)
            {
                profile.Add(name, null);
            }
            foreach (string name in myNames)
            {
                rando = rand.Next(0, myNames.Length);
                Console.WriteLine(rando);
                profile[name] = flavors[rando];
            }

            foreach (KeyValuePair<string,string> entry in profile)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }

        }
    }
}
