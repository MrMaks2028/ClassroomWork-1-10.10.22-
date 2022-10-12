using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomWork_1__10._10._22_
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] tmp = new int[args.Length];
            int[] numbers = new int[args.Length];
            int count = 0, sum = 0;

            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = Convert.ToInt32(args[i]);
                if (tmp[i] % 2 == 0 && tmp[i] % 11 == 0)
                {
                    sum += tmp[i];
                    count++;
                }
            }
            numbers = new int[count];
            for(int i = 0; i < numbers.Length; i++)
            {
                if (tmp[i] % 2 == 0 && tmp[i] % 11 == 0)
                {
                    numbers[i] = tmp[i];
                }
            }
            numbers.ToList();
            Console.Write($"Сумма - {sum} и числа - ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
