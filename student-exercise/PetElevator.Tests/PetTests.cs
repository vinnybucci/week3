using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.CRM;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.Tests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void ListTest()
        {
            
            
            Pet pet = new Pet("PetName", "Species");
            List<string> testList = new List<string>();
            testList.Add("Rabies");
            testList.Add("Distemper");
            testList.Add("Parvo");
            List<string> results = new List<string>();
            pet.Vaccinations = testList;
            pet.ListVaccinations();

        }
    }
}
