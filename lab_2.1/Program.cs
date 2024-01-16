using System;
using System.Collections.Generic;

namespace lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int sum = 0;

            if(args.Length > 0)
            {
                for (int i = 0; i <= args.Length - 1; i ++ )
                {
                    if(int.TryParse(args[i], out var number))
                    {
                        nums.Add(number);
                        sum += number;
                        Console.WriteLine(number);
                    }
                }
                Console.WriteLine($"Сумма чисел: {sum}");
            }
        }
    }
}
