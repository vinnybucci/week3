using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.Tests
{ 
    [TestClass]
  public class CustomerTests
    {
        [TestMethod]
        public void GetBalanceDueTest()
        {
            Dictionary<string, double> balanceTest = new Dictionary<string, double>()
            {
                {"Grooming", 49.99 },
                {"Walking", 29.99 },
                {"Sitting", 15.99 }



            };
            Customer customer = new Customer("firstName", "lastName");
            double results = customer.GetBalanceDue(balanceTest);
            double expected = 95.97;
            Assert.AreEqual(expected, results);

        }
    }
}
