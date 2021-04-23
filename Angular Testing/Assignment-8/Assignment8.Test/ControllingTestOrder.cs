﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Assignment8.Test
{

    /// <summary>
    /// Test class for making serial order of execution of test cases.
    /// </summary>
    public class TestStructure
    {
        public Action Test;
    }

    class Int
    {
        public int I;
    }

    [TestFixture]
    public class ControllingTestOrder
    {
        private static readonly Int MyInt = new Int();

        [OneTimeSetUp]
        public void SetUp() => MyInt.I = 0;

        [OrderedTest(0)]
        public void test0()
        {
            Console.WriteLine("This is test zero");
            Assert.That(MyInt.I, Is.EqualTo(0));
        }

        [OrderedTest(2)]
        public void test1()
        {
            Console.WriteLine("This is test two");
            MyInt.I++;
            Assert.That(MyInt.I, Is.EqualTo(2));
        }


        [OrderedTest(1)]
        public void test2()
        {
            Console.WriteLine("This is test one");
            MyInt.I++; 
            Assert.That(MyInt.I, Is.EqualTo(1));
        }

        [OrderedTest(3)]
        public void test3()
        {
            Console.WriteLine("This is test three");
            MyInt.I++; Assert.That(MyInt.I, Is.EqualTo(3));
        }


        [TestCaseSource(sourceName: "TestSource")]
        public void MyTest(TestStructure test)
        {
            test.Test();
        }

        public static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                Dictionary<int, List<MethodInfo>> methods = assembly
                    .GetTypes()
                    .SelectMany(x => x.GetMethods())
                    .Where(y => y.GetCustomAttributes().OfType<OrderedTestAttribute>().Any())
                    .GroupBy(z => z.GetCustomAttribute<OrderedTestAttribute>().Order)
                    .ToDictionary(gdc => gdc.Key, gdc => gdc.ToList());

                foreach (var order in methods.Keys.OrderBy(x => x))
                {
                    foreach (var methodInfo in methods[order])
                    {
                        MethodInfo info = methodInfo;
                        yield return new TestCaseData(
                            new TestStructure
                            {
                                Test = () =>
                                {
                                    object classInstance = Activator.CreateInstance(info.DeclaringType, null);
                                    info.Invoke(classInstance, null);
                                }
                            }).SetName(methodInfo.Name);
                    }
                }

            }
        }
    }
}
