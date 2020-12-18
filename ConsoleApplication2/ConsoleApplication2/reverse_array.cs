using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    //SAMPLE INPUT
    //3 
    //1
    //2
    //3
    //4

    //SAMPLE OUTPUT
    //4
    //3
    //2
    //1
    class reverse_array
    {
        public static void reverseArray()
        {
            int testcase = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[testcase];
            for (int i = 0; i < testcase; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reversed Array");
            for (int j = array.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(array[j]);
            }
            Console.ReadLine();
        }
    }
}
