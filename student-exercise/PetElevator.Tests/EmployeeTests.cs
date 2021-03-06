using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.HR;

namespace PetElevator.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void FullNameReturnsCorrectFormat()
        {
            Employee employee = new Employee("Test", "Testerson");

            string fullName = employee.FullName;

            Assert.AreEqual("Testerson, Test", fullName);
        }

        [TestMethod]
        public void RaiseSalaryTest_Positive()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(5); //raise 5%

            Assert.IsTrue(employee.Salary == 100 * 1.05);
        }

        [TestMethod]
        public void RaiseSalaryTest_Negative()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(-10); //"raise" by negative 10%

            Assert.AreEqual(100, employee.Salary); //salary should remain same
        }
        [TestMethod]
        public void GetBalanceDueTest()
        {
            Dictionary<string, double> balanceTest = new Dictionary<string, double>()
            {
                {"Grooming", 49.99 },
                {"Walking", 29.99 },
                {"Sitting", 15.99 }



            };
            Employee employee = new Employee("firstName", "lastName");
            double results = employee.GetBalanceDue(balanceTest);
            double expected = 80.975;
            Assert.AreEqual(expected, results);

        }
        [TestMethod]
        public void GetBalanceNullTest()
        {
            Dictionary<string, double> balanceTest =null;
            Employee employee = new Employee("firstName", "lastName");
            double results = employee.GetBalanceDue(balanceTest);
            double expected = 0;
            Assert.AreEqual(expected, results);

        }
        [TestMethod]
        public void EmptyDictionaryTest()
        {
            Dictionary<string, double> balanceTest = new Dictionary<string, double>();
          
               
            Employee employee = new Employee("firstName", "lastName");
            double results = employee.GetBalanceDue(balanceTest);
            double expected = 0;
            Assert.AreEqual(expected, results);

        }

    }
}
