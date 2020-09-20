using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace training
{
    public class GetTheRange
    {

        public  void range()
        {
            Console.WriteLine("please enter the array length");

            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the array Numbers");
            var nums = new List<int>();
            for (int i = 0; i < count; i++)
            {
                nums.Add(Convert.ToInt32(Console.ReadLine()));

            }
            Console.Write("the output--> ");
            Console.WriteLine((nums[nums.Count - 1] - nums.FirstOrDefault()) + 1 - nums.Count);

         
         
        }

    }
}
