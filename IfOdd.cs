using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace training
{
   public class IfOdd
    {
        public IfOdd()
        {

        }
        public bool odd()
        {
            Console.WriteLine("please enter the array length");

            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the array Numbers");
            var array = new List<int>();
            for(int i=0;i<count;i++)
            {
                array.Add(Convert.ToInt32(Console.ReadLine()));

            }
            return array.Any(x => (x % 2 != 0));

        }
    }
}
