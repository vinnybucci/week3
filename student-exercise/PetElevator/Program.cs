﻿using System;
using System.Collections.Generic;

namespace PetElevator
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pet pet = new Pet("PetName", "Species");
            List<string> testList = new List<string>();
            testList.Add("Rabies");
            testList.Add("Distemper");
            testList.Add("Parvo");
            List<string> results = new List<string>();
            pet.Vaccinations = testList;
            pet.ListVaccinations();
            Console.WriteLine(pet.ListVaccinations());
        }
    }
}
