using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestWork.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductAnalysis_CheckOutcomes_LargestOfThree()
        {
            int [,] diagnose = {
                { 2, 4, 6 },
                { 6, 4, 2 },
                { 4, 6, 2 }
            };

            int numberRows = diagnose.GetLength(0);
            int numberColumns = diagnose.GetLength(1);

            int resultBest = 6;

            for (int i = 0; i < numberRows; i++)
            {
                int a = diagnose[i, 0];
                int b = diagnose[i, 1];
                int c = diagnose[i, 2];
                int result = Program.CheckValue(a, b, c);
                Assert.IsTrue(resultBest == result);
            }
        }
    }
}
