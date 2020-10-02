using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator;
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
            
            //Arrange
            Pet pet = new Pet("PetName", "Species");
            List<string> testList = new List<string>();
            testList.Add("Rabies");
            testList.Add("Distemper");
            testList.Add("Parvo");            
            pet.Vaccinations = testList;
            string expected = "Rabies, Distemper, Parvo";
            //Assert
            Assert.AreEqual(expected,pet.ListVaccinations());


        }
    }
}
