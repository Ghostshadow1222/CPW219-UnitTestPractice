using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests;

[TestClass()]
public class SimpleMathTests
{
    [TestMethod()]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    [DataRow(0, -0)]
    public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
    {
        double expected = num1 + num2;
        double actual = SimpleMath.Add(num1, num2);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    [DataRow(0, -0)]
    public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
    {
        double expected = num1 * num2;
        double actual = SimpleMath.Multiply(num1, num2);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Divide_DenominatorZero_ThrowsArgumentException()
    {
        var ex = Assert.ThrowsExactly<ArgumentException>(() => SimpleMath.Divide(5, 0));
        Assert.AreEqual("Denominator cannot be zero", ex.Message);
    }

    [TestMethod]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    [DataRow(0, -0)]
    public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
    {
        if (num2 == 0)
        {
            Assert.ThrowsExactly<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }
        else
        {
            double expected = num1 / num2;
            double actual = SimpleMath.Divide(num1, num2);
            Assert.AreEqual(expected, actual);
        }
    }

    [TestMethod]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    [DataRow(0, -0)]
    public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
    {
        double expected = num1 - num2;
        double actual = SimpleMath.Subtract(num1, num2);
        Assert.AreEqual(expected, actual);
    }
}