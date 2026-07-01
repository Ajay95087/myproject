using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class program
    {
    
        static void Main(string[] args)
        {
            //int[]arr = { 1,2,3,4,5,6,7,8,9,10};
            //int min = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //       min = arr[i];
            //    }
            //}
            //Console.WriteLine( "Min number is: "+min);


            //int[] b = { 54, 50, 21, 35, 66, 58, 83, 42 };

            //int max = b[0];

            //for (int i = 1; i < b.Length; i++)
            //{
            //    if(b[i] > max)
            //    {
            //        max = b[i];
            //    }
            //}
            //Console.WriteLine("Max number is: " + max);

            //int[] b = { 54, 50, 21, 35, 66, 58, 83, 42 };

            //Console.WriteLine("Max number is: " + b.Max());

            int[] b = { 54, 50, 21, 35, 66, 58, 83, 42 };

            System.Array.Sort(b);


            Console.WriteLine(" Second highest number is: " + b[b.Length - 2]);

        }

        
    }
}
