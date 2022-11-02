using System;

namespace class_code_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入已知点名：");
            string name1 = Console.ReadLine();//已知点点号
            Console.WriteLine("请输入未知点名：");
            string name2 = Console.ReadLine();//未知点点号
            Console.WriteLine("请输入已知点高程：");
            double H = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入观测高差：");
            double diff = Convert.ToDouble(Console.ReadLine());

            Altitude obj = new Altitude(name1, name2, H, diff);
            obj.Calc();
            obj.Print();//格式化输出
            Console.ReadKey();

        }
    }
}
