using System;
using System.Collections.Generic;
using System.Linq;

namespace training
{


    class Program
    {

        public void odd(List<int> nums)
        {
            bool if_odd = nums.Any(x => (x % 2 != 0));


            Console.WriteLine(if_odd);

        }
        public void paint(int num)
        {
            for (int i = num; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Task1");
            var oddObj = new IfOdd();
            if (oddObj.odd())
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine();
            Console.WriteLine("Task2");
            var RangeObj = new GetTheRange();
            RangeObj.range();
            Console.WriteLine();
            Console.WriteLine("Task3");
            var triangleObj = new triangle();
            triangleObj.paint();
            Console.WriteLine();
            Console.WriteLine("Task4");
            var max = new getMax();
            max.getLargest();
            Console.WriteLine();
            Console.WriteLine("Task5");
            var sumobj = new SumAndAverage();
            sumobj.sumAndAverage();
            Console.WriteLine();
            Console.WriteLine("Task6");
            var sum = new SumRange();
            sum.sumRange();
            Console.WriteLine();
            Console.WriteLine("Task7");
            var dimond = new Dimond();
            dimond.display();
          
        }

}
}
