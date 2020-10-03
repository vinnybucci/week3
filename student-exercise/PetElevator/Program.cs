using System;
using System.Collections.Generic;

namespace PetElevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double price = 0;
            string halfOff = "Walking";
            Dictionary<string, double> balanceTest = new Dictionary<string, double>()
            {
                { "Grooming", 49.99 },
                { "Walking", 29.99 },
                { "Sitting", 15.99 }
            };
            foreach (KeyValuePair<string, double> value in balanceTest)
            {
                if (value.Key == halfOff)
                {
                    price = price+ value.Value / 2;
                }
                else
                {
                    price += value.Value;
                }

            }
            }

        }
    }
