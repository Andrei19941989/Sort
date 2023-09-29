using System;

namespace Sort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] num = new int[5] {1, 4, 2, 9, 7};
            Sortirovka(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]+ " ");
            }
        }



        static void Sortirovka(int[] mass)
        {
            int p;
            bool sorted = false;
            while (sorted == false)
            {
                sorted = true;
                for (int j = 0; j < mass.Length-1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        p = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = p;
                        sorted = false;
                    }
                }
            }
        }
    }
}
            
    