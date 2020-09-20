using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace training
{
    public class getMax
    {
        public void getLargest()
        {
            Console.WriteLine("please enter the 3 numbers");
            int Max = 0;
            for (int i = 0; i < 3; i++)
            {
                 var input =Convert.ToInt32(Console.ReadLine());
                if (input > Max)
                    Max = input;

            }
            Console.Write("the maximum number");
            Console.WriteLine(Max);
        }
    }
}