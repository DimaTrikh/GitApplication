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
        public static void MatrixB(int w, int h)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Random rnd = new Random();
            for(int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(rnd.Next(0, 2));

                }

                Console.WriteLine();
            }

        }
    }
}
