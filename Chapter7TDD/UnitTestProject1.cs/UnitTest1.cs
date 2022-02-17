using System;
using Chapter7TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // create an object to test
            Student s = new Student();
            // define a test input and output value
            int score = 90;
            char expectedResult = 'A';
            // run the method unuder test
            char actualResult = s.GetLetterGrade(score);
            // verfiy the result
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // create an object to test
            Student s = new Student();
            // define a test input and output value
            for(int score = 90; score <= 100; score++)
            {
                char expectedResult = 'A';
                // run method under test
                char actualResult = s.GetLetterGrade(score);
                // verify the result
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

    }
}
