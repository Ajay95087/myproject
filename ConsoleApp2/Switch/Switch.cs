using System;


namespace Switch
{
    internal class Switch
    {
        static void Main()
        {
            //int num = 46;
            //if(num % 2 == 0)
            //{
            //    Console.WriteLine("number is Even");
            //}
            //else
            //{
            //    Console.WriteLine("number is Odd");
            //}

            int day = 3;

            switch (day)
            {
                case 1:
                    {
                        Console.WriteLine(" Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" wednesday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Numver is not match");
                        break;
                    }

            }





        }
    }
}
