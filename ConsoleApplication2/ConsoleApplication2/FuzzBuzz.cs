using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    //SAMPLE INPUT
    //2
    //3,15

    //SAMPLE OUTPUT
    //1
    //2
    //Fizz
    //1
    //2
    //Fuzz
    //4
    //Buzz
    //Fuzz
    //7
    //8
    //Fuzz
    //Buzz
    //11
    //Fuzz
    //13
    //14
    //FuzzBuzz
    class FuzzBuzz
    {
        public static void method(int[] tests)
        {
            int i, j, k;

            for (j = 0; j < tests.Length; j++)
            {
                for (k = 1; k <= tests[j]; k++)
                {
                    if ((k % 3 == 0) && (k % 5 == 0))
                        Console.WriteLine("FizzBuzz");
                    else if (k % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (k % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(k);
                }

            }
        }
    }
}
