using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_two_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //we target = 9
               int sum = 0;
               int[] a = { 7, 2, 91, 10, 12, 15, 17, 18, 19 };
               sum=  a[0] + a[1];
            if(sum==9)
            {
                Console.WriteLine(" we have the answer =  " + sum);
            }

        }
    }
}
