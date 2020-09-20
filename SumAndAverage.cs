using System;
using System.Collections.Generic;
using System.Text;

namespace training
{
    class SumAndAverage
    {
        public void sumAndAverage()
        {
          
            Console.WriteLine("please enter the 10 Numbers");
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum+=Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("the sum-->");
            Console.WriteLine(sum);
            Console.Write("the avg-->");
            Console.WriteLine(sum/10);
        }
    }
}