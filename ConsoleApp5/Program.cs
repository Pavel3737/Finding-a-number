using System;

namespace Vis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            // input 
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Введите число номер {i + 1}:");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ваши числа");
            //output
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} ");
            }
        }
    }
}