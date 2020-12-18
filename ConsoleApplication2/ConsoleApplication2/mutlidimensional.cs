using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    //SAMPLE INPUT
    //3 5
    //13 4 8 14 1
    //9 6 3 7 21
    //5 12 17 9 3

    //SAMPLE OUTPUT
    //13 9 5
    //4 6 12
    //8 3 17
    //14 7 9
    //1 21 3
    class mutlidimensional
    {
        public static void multidimension()
        {
            int rows = Int32.Parse(Console.ReadLine().Trim());
            int cols = Int32.Parse(Console.ReadLine().Trim());
            int[,] twodarray = new int[rows, cols];
            int[,] reversetwodarray = new int[cols,rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    twodarray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int col=0;col<twodarray.GetLength(1);col++)
            {
                for(int row=0;row< twodarray.GetLength(0); row++)
                {
                    reversetwodarray[col, row] = twodarray[row, col];
                    Console.Write(reversetwodarray[col, row] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
