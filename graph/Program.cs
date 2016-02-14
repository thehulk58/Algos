using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.NegativeGraph();
        }
        public void positiveGraph()
        {

            int[] array = { 4, 2, 1 };
            int max = 4;
            for (int row = max; row >= 1; row--)
            {

                for (int col = 0; col < array.Length; col++)
                {
                    if (array[col] >= row)
                        Console.Write("* ");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        ///
        ///
        ///
        public void NegativeGraph()
        {

            int[] array = { 4, 2, -2, 4, 0, 5 };
            int max = array.Max();
            int min = array.Min();
            int tot = max - min;




            for (int row = tot; row >= 1; row--)
            {
                int finalRow = row + min;

                for (int col = 0; col < array.Length; col++)
                {
                    if (finalRow > array[col] && finalRow > 0)
                        Console.Write("_");
                    else if (finalRow <= array[col] && finalRow > 0)
                        Console.Write("*");
                    else if (finalRow < 1 && array[col] > 0)
                        Console.Write("_");
                    else if (finalRow < 1 && array[col] < 0)
                        Console.Write("*");
                    else if (array[col] == 0)
                        Console.Write("_");
                    else
                        Console.Write("_");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}
