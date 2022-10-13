using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace ClassroomWork_1__10._10._22_
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] tmp = new int[args.Length];
            int[] nums = new int[args.Length];
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

            nums = new int[count];

            for (int i = 0; i < count; )
            {
                for (int j = 0; j < tmp.Length; j++)
                {
                    if (tmp[j] % 2 == 0 && tmp[j] % 11 == 0)
                    {
                        nums[i] = tmp[j];
                        i++;
                    }
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string summ = "summ.txt", numbers = "numbers.txt";

            var sw = new StreamWriter(path + "\\" + summ, false);
            sw.WriteLine($"Сумма - {sum}");
            sw.Close();

            sw = new StreamWriter(path + "\\" + numbers, false);
            sw.Write("Числа - ");
            for (int i = 0; i < nums.Length; i++)
            {
                sw.Write($"{nums[i]} ");
            }
            sw.Close();

            var sr = new StreamReader(path + "\\" + summ);
            string line1;
            while ((line1 = sr.ReadLine()) != null)
            {
                Console.WriteLine(line1);
            }
            sr.Close();

            sr = new StreamReader(path + "\\" + numbers);
            string line2;
            while ((line2 = sr.ReadLine()) != null)
            {
                Console.WriteLine(line2);
            }
            sr.Close();

            Console.ReadKey();
        }
    }
}
