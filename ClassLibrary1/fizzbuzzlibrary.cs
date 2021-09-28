using System;

namespace ClassLibrary1
{
    public class fizzbuzzlibrary
    {


        // var []
        public static string onetohundred(int i) {


            string[] value = new string[100];

   

                if (i % 3 == 0 && i % 5 == 0)
                {
                    value[i-1] ="fizz buzz";
                }
                else if (i % 3 == 0)
                {
                    value[i - 1] = "fizz";

                }
                else if (i % 5 == 0)
                {
                    value[i - 1] = "buzz";

                }
                else
                {
                    value[i - 1] = ""+i;
                }

            



            return value[i-1];
        }



    }
}
