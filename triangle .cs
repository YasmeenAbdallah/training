using System;
using System.Collections.Generic;
using System.Text;

namespace training
{
    public class triangle
    {
        public void paint()

        {

            Console.WriteLine("please enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}
