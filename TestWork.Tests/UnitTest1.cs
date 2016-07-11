using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestWork.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductAnalysis_CheckOutcomes_AllPositive()
        {
            int[,] numbers =
            {
                { 2, -4, -6},
                {-2,  4, -6},
                { 2,  4,  6},
                {-2, -4,  6}
            };

            int numberRows = numbers.GetLength(0);
            int numberColumns = numbers.GetLength(1);

            bool positiveResult = false;
            for(int i =0; i < numberRows; i++)
            {
                int a = numbers[i, 0];
                int b = numbers[i, 1];
                int c = numbers[i, 2];
                positiveResult = Program.CheckSign(a,b,c);
                Assert.IsTrue(positiveResult);
            }

        }

        [TestMethod]
        public void ProductAnalysis_CheckOutcomes_AllNegative()
        {
            int[,] numbers =
            {
                {-2, -4, -6},
                { 2,  4, -6},
                {-2,  4,  6},
                { 2, -4,  6}
            };

            int numberRows = numbers.GetLength(0);
            int numberColumns = numbers.GetLength(1);

            bool negativeResult = true;
            for (int i = 0; i < numberRows; i++)
            {
                int a = numbers[i, 0];
                int b = numbers[i, 1];
                int c = numbers[i, 2];
                negativeResult = Program.CheckSign(a, b, c);
                Assert.IsFalse(negativeResult);
            }
        }
    }
}
