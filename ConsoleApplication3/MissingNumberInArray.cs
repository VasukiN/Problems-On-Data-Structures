//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApplication1
//{
//    class MissingNumberInArray
//    {
        
//        public static void Main(string[] args)
//        {
//            List<int> NewArray = new List<int>();
//            int test_case;int missing_Element=0;
//            Console.WriteLine("Please enter the number of test cases");
//            test_case = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < test_case; i++)
//            {
//                Console.WriteLine("Please enter the size of the array");
//                int n = Convert.ToInt32(Console.ReadLine());
//                int[] A = new int[n];
//                Console.WriteLine("Please ente the elements");
//                for (int j = 0; j < n - 1; j++)
//                {
//                    A[j] = Convert.ToInt32(Console.ReadLine());
//                    NewArray.Add(A[j]);
//                }
//                for (int k = 1; k < n; k++)
//                {
//                    foreach (var v in A)
//                        if (k == v)
//                        {
//                            NewArray.Remove(v);
//                            A = NewArray.ToArray();
//                            break;
//                        }
//                        else
//                            missing_Element = k;
//                }
//                Console.WriteLine("Missing Element in the array is {0}", missing_Element);

//            }
            
//        }
//    }
//}
