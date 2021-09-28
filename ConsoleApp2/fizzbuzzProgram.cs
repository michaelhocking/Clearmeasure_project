using System;

namespace ConsoleApp2
{
    class fizzbuzzProgram
    {
        static void Main(string[] args)
        {

            for (int j = 1; j <= 100; j++)
            {
                string holder = ClassLibrary1.fizzbuzzlibrary.onetohundred(j);
                Console.WriteLine(holder);

            }

        }
    }
}
