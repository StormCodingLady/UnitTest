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
            int[,] diagnose;

            diagnose  {
                { 2, 4, 6 },
                { 6, 4, 2 },
                { 4, 6, 2 },
            }



            bool result = Program.CheckSign();

            Assert.IsTrue(result);
        }
    }
}
