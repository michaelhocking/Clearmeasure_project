using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class fizzbuzzUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange

            string[] verifiedvalue = new string[100];

            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    verifiedvalue[i - 1] = "fizz buzz";
                }
                else if (i % 3 == 0)
                {
                    verifiedvalue[i - 1] = "fizz";

                }
                else if (i % 5 == 0)
                {
                    verifiedvalue[i - 1] = "buzz";

                }
                else
                {
                    verifiedvalue[i - 1] = "" + i;
                }

            }

            

            
            for (int j =1;j<=100;j++) {
              string holder =  ClassLibrary1.fizzbuzzlibrary.onetohundred(j);
              string holder2 = verifiedvalue[j - 1];
                Assert.Equals(holder,holder2);
            }

        }
    }
}
