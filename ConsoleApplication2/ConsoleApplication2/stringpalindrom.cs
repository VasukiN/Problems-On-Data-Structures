using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class stringpalindrom
    {
        public static void getstringpalindrom()
        {
            string word = Console.ReadLine();
            int j = 0;
            int length = word.ToCharArray().Length;
            char[] chararray = new char[length];
            for (int i = length-1; i >= 0; i--)
            {
                chararray[j] = word.ToCharArray()[i];
                j++;
            }
            string reverse = new string(chararray);
            if (word == reverse)
                Console.WriteLine("Indeed");
            else
                Console.WriteLine("Not At All");
        }
  
    }

}
