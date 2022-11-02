using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入点名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入点的高程");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入点号的X");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入点号的y");
            double Y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("点{0}\n高程为:{1}\n点{0}的坐标为:\nX = {2}\nY = {3}",name,height,X,Y);
            Console.ReadKey();
        }
    }
}
