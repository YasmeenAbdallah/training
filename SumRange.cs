using System;
using System.Collections.Generic;
using System.Text;

namespace training
{
    class SumRange
    {
        public void sumRange()
        {
            int sumRange = 0;
           
            for (int i = 100; i <=200; i++)
            {
                if (i % 9==0)
                {
                    sumRange += i;
                    Console.Write(" " +i);
                }

              
            }
            Console.WriteLine();
            Console.WriteLine("the sum of integers the divisable by 9--|>"+sumRange);
        }
    }
}
