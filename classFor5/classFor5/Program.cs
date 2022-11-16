using System;

namespace classFor5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择作业2：2  or 作业3：3");
            if (Console.ReadLine() == "2")
            {
                HomeWork2();
            }
            else
            {
                Console.WriteLine("请输入是否连续输入y/n\n连续输入用,隔开\ntips:x,y,x,y,x,y");
                if (Console.ReadLine() == "y")
                {
                    getNum();
                }
                else
                {
                    HomeWork3();
                }
            }
        }
        /// <summary>
        /// 作业三的单点输入函数
        /// </summary>
        public static void HomeWork3()
        {
            Console.WriteLine("请输入坐标：\ntips: x,y ");
            string[] res = Console.ReadLine().Split(',');

            int x = Convert.ToInt32(res[0]);
            int y = Convert.ToInt32(res[res.Length - 1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("第一象限");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("第二象限");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("第三象限");
            }
            else if (x == 0 || y == 0)
            {
                Console.WriteLine("在坐标轴上");
            }
            else
            {
                Console.WriteLine("第四象限");
            }
        }
        /// <summary>
        /// 作业二的启动函数
        /// </summary>
        public static void HomeWork2()
        {
            while (true)
            {
                if (!Getline())
                {
                    break;
                }
            }
        }
        /// <summary>
        /// 作业二的判断函数
        /// </summary>
        /// <returns>返回输入是否正确</returns>
        public static bool Getline()
        {
            Console.WriteLine("请输入成绩：（输入不在0-100的数字退出）");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade > 100 || grade < 0)
            {
                return false;
            }
            switch (grade / 10)
            {
                case 10:
                case 9: Console.WriteLine("你的成绩评级是A"); break;
                case 8: Console.WriteLine("你的成绩评级是B"); break;
                case 7: Console.WriteLine("你的成绩评级是C"); break;
                case 6: Console.WriteLine("你的成绩评级是D"); break;
                default: Console.WriteLine("你的成绩评级是不及格"); break;
            }
            return true;
        }
        /// <summary>
        /// 作业三的连续输入函数
        /// </summary>
        public static void getNum()
        {
            Console.WriteLine("请输入数据：");
            string[] res = Console.ReadLine().Split(',');


            for (int i = 0; i < res.Length;)
            {
                int x = Convert.ToInt32(res[i++]);
                int y = Convert.ToInt32(res[i++]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("第一象限");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("第二象限");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("第三象限");
                }
                else if (x == 0 || y == 0)
                {
                    Console.WriteLine("在坐标轴上");
                }
                else
                {
                    Console.WriteLine("第四象限");
                }
            }
        }
    }
}
