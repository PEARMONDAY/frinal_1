using System;

namespace frinal_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, height;
            int[,] num = new int[3, 3];
            num[0, 0] = int.Parse(Console.ReadLine());
            num[0, 1] = int.Parse(Console.ReadLine());
            num[0, 2] = int.Parse(Console.ReadLine());
            num[1, 0] = int.Parse(Console.ReadLine());
            num[1, 1] = int.Parse(Console.ReadLine());
            num[1, 2] = int.Parse(Console.ReadLine());
            num[2, 0] = int.Parse(Console.ReadLine());
            num[2, 1] = int.Parse(Console.ReadLine());
            num[2, 2] = int.Parse(Console.ReadLine());
            
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (width = 0; width < 3; width++)
            {
                for (height = 0; height < 3; height++)
                {
                    Console.Write(num[width, height]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
