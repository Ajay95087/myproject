using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loop
{
    internal class While
    {
        static void Main(string[] args)
        {

            //  -----  1 to 10 counting ----

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //  -----  Sum of numbers from 1 to n ----

            Console.WriteLine("Enter the number of elements you want to store in array");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sum = 0;   

            while (i <= num)
            {
                sum = sum + i;
                i++;
            }

            Console.WriteLine("sum : " + sum);

        }
    }
}
