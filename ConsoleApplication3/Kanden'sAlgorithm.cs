//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        public static int  sum = 0;
//        //static int sum1 = 0;
//        //public static void FindMaximum(int[] A, int T)
//        //{
//        //    for (int i = 0; i < T; i++)
//        //    {
//        //        for (int j = 0; j < A.Length; j++)
//        //        {
//        //            sum = sum + A[j];
//        //        }
//        //        Console.WriteLine("Maximum sum of the Array is {0}",sum);
//        //    }
            
//        //}
//        static void Main(string[] args)
//        {
//            int n; int test_case; int[] A = { };
//            Console.WriteLine("Please enter the number of test case");
//            test_case = Convert.ToInt32(Console.ReadLine());
//            for(int i=0;i<test_case;i++)
//            {
//                Console.WriteLine("Please enter the size of the Array");
//                n = Convert.ToInt32(Console.ReadLine());
//                A = new int[n];
//                Console.WriteLine("Please enter the Array Elements");
//                for (int j = 0; j < n; j++)
//                {
//                    A[j] = int.Parse(Console.ReadLine());
//                }
//                for (int k = 0; k < A.Length;k++)
//                    if (A[k] < 0)
//                    {
//                        sum = A[0];
//                        if (sum < A[k])
//                            sum = A[k];
//                    }
//                    else
//                        sum = sum + A[k];
//                Console.WriteLine("Maximum sum of each array is {0}", sum);
//                //Console.WriteLine("Maximum sum of each array is {0}", sum1);
//            }
            
//        }
//    }
//}
