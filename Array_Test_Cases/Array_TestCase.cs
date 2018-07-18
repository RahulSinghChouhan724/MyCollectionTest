using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MycollectionTest;


namespace Array_Test_Cases
{
    [TestClass]
    public class Array_TestCase
    {
        [TestMethod]
        //checkRollNoIsNotNullable
        public void CheckRollNoIsNotNullable()
        {
            var P = new Person();
            P.RollNo = 101;
            var t = P.RollNo; 
            Assert.Equals(t, null);
        }

        [TestMethod]
        public void CheckUserIdIsStringOrNot()
        {
           
            
        }
        

    }
}
