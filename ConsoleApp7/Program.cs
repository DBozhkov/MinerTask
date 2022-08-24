using System;
using System.Collections.Generic;
using System.Linq;

namespace TempWork
{
    class Program
    {
        static void Main()
        {
            string command = string.Empty;
            Dictionary<string, int> resourceCounter = new Dictionary<string, int>();
            int quantity;
            string tempKey = string.Empty;
            int counter = 1;
            while ((command = Console.ReadLine()) != "stop")
            {
                if (counter % 2 != 0)
                {
                    tempKey = command;
                    if (!resourceCounter.ContainsKey(command))
                    {  
                        resourceCounter.Add(command, 0);
                    }
                }
                if (counter % 2 == 0)
                {
                    
                    quantity = int.Parse(command);
                    if (resourceCounter.ContainsKey(tempKey))
                    {
                        resourceCounter[tempKey] += quantity;
                    }
                }
                counter++;
                
            }

            
            foreach (KeyValuePair<string,int> pair in resourceCounter)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
