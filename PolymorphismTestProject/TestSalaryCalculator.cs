using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;
using System;

namespace PolymorphismTestProject
{
    [TestClass]
    public class TestSalaryCalculator
    {
        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursReturns2800Dollars()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = wage * 40;
            Employee e = new Employee();

            string expectedResponse = $"\nThis ANGRY EMPLOYEE worked {weeklyHours} hrs. " +
                                        $"Paid for 40 hrs at $ {wage}" +
                                        $"/hr = ${salary} \n";
            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursReturns3850Dollars()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = wage * weeklyHours;
            Contractor c = new Contractor();

            string expectedResponse = $"\nThis HAPPY CONTRACTOR worked {weeklyHours} hrs. " +
                                        $"Paid for {weeklyHours} hrs at $ {wage}" +
                                        $"/hr = ${salary} ";
            string response = c.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }

    }
}
