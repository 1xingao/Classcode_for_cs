using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace classFor_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../data.txt";
            StreamReader file = new StreamReader(path);
            string[] Rc = file.ReadLine().Split(',');
            int Row = Convert.ToInt32(Rc[0]);
            int Col = Convert.ToInt32(Rc[1]);
            double[,] data = new double[Row, Col];
            string[] RealDate = file.ReadLine().Split(',');
            int index = 0;
            for(int i = 0; i < Row; i++)
            {
                for(int j = 0; j < Col; j++)
                {
                    data[i, j] = Convert.ToDouble(RealDate[index++]);
                }
            }
            //Print
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Console.Write($" |  {data[i, j]}  |");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
