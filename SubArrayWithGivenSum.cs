using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SubArrayWithGivenSum
    {
        public static void Main(string[] args)
        {
            int test_case; int size=0; int sum;int elementsum=0;int first=0;int last=0;
            Console.WriteLine("Please enter the number test cases");
            test_case = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < test_case; i++)
            {
                Console.WriteLine("Please enter the size and sum for array");
                size = Convert.ToInt32(Console.ReadLine());
                sum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the array elemennts");
                int[] A = new int[size];
                for (int j = 0; j < size; j++)
                    A[j] = Convert.ToInt32(Console.ReadLine());
                for (int k = 0; k < size; k++)
                {
                    elementsum = A[k];
                    for(int m=k+1;m<size;m++)
                    {
                             elementsum += A[m];
                             if (sum == elementsum)
                             {
                                 first = k;
                                 last = m;
                                 Console.WriteLine("Sum of element from  " + first + " position to  " + last + " position is " + sum + "");
                                 break;
                             }
                    }
                    elementsum = 0;
                }
                
            }


        }
    }
}
