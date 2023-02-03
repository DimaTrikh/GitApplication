using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }


        public static void MatrixA(int w, int h)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random rnd = new Random();
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(rnd.Next(0, 2));
                }
                Console.WriteLine();
            }
        }

        public static void PrintMyName()
        {
            Console.WriteLine("Trikhunkov Dmitry Sergeevich");
            Console.WriteLine("10.4");
            Console.WriteLine("October, 18");
        }


    }
}
