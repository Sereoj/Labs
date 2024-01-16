using System;
using System.Text;

namespace lab_2._2
{
    class Program
    {
        public static string intToBinary(int num)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int index = 0; index <= 31; index++)
            {
                stringBuilder.Append(num & 1);
                num >>= 1;
                if (index != 31 && (index + 1) % 8 == 0)
                {
                    stringBuilder.Append(" ");
                }
            }
            return stringBuilder.ToString();
        }
        static void Main(string[] args)
        {
            int num = 10;
            Console.WriteLine(num);
            Console.WriteLine(intToBinary(num));
        }
    }
}
