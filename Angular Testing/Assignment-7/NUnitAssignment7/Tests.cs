using NUnit.Framework;
using Services;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NUnitAssignment7
{
    [TestFixture]
    public class Tests
    {
        private Service _service;
        private static object[] oddNumbersLists =
        {
            new object[] {new List<int> {1}},
            new object[] {new List<int> {1,3,5}},
        };

        [SetUp]
        public void Setup()
        {
            _service = new Service();
        }


        // 1: Testing of while loop
        [TestCase(-1, 9)]
        [TestCase(0, 10)]
        [TestCase(1, 11)]
        public void Add10_Test(int value, int expected)
        {
            // Act
            var result = _service.Add10(value);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // 2: Testing of switch case
        [TestCase("Male", 1)]
        [TestCase("Female", 2)]
        [TestCase("Other", 3)]
        [TestCase("Prefer not to say", 4)]
        [TestCase("", -1)]
        public void GetGenderCode_Test(string value, int expected)
        {
            // Act
            var result = _service.GetGenderCode(value);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // 3: Testing of if-else
        [TestCase(2, true)]
        [TestCase(1, false)]
        [TestCase(0, true)]
        public void IsEven_Test(int value, bool expected)
        {
            // Act
            var result = _service.IsEven(value);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // 4: Testing of for-each
        [TestCaseSource(typeof(OddNumberListClass), nameof(OddNumberListClass.TestCases))]
        public int FindOddNumbers_Test(List<int> values)
        {
            // Act
            var result = _service.FindOddNumbers(values);

            // Assert
            return result;
        }

        // 5: Testing of for loop
        [TestCase(11, 1)]
        [TestCase(10, 0)]
        public void Subtract10_Test(int value, int expected)
        {
            // Act
            var result = _service.Subtract10(value);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // 6: Testing of exception handling
        [Test]
        public void Divide_Test()
        {
            // Act, Assert
            Assert.Throws<InvalidOperationException>(() => _service.Divide(1, 0));
        }

        // 7: Testing of exception handling
        [Test]
        public void GetGender_Test()
        {
            // Act, Assert
            Assert.Throws<ArgumentNullException>(() => _service.GetGenderCode(null));
        }

        // 8: Testing of exception handling
        [Test]
        public void NotImplemented_Test()
        {
            // Act, Assert
            Assert.Throws<NotImplementedException>(() => _service.NotImplemented());
        }

        // 9: Testing of exception handling
        [Test]
        public void ValidateName_Test1()
        {
            // Act, Assert
            Assert.Throws<InvalidNameException>(() => _service.ValidateName("Abhimanyu Singh"));
        }

        // 10: Testing of exception handling
        [Test]
        public void ValidateName_Test2()
        {
            // Act, Assert
            Assert.Throws<FormatException>(() => _service.ValidateName(null));
        }
    }
}

public class OddNumberListClass
{
    public static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData(new List<int> { 1 }).Returns(1);
            yield return new TestCaseData(new List<int> { 1, 3, 5 }).Returns(3);
        }
    }
}