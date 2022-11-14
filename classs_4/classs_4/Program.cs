using System;

namespace classs_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取点名
            //tips:   var为自动推导类型，慎用
            var pointName = Console.ReadLine();
            var pointNameList = pointName.Split(',');

            //获取点的数量
            int n = pointNameList.Length;

            //获取各点间高差
            var pointHid = Console.ReadLine();
            string[] _pointHidList = pointHid.Split(',');
            double[] pointHidList = new double[n];

            //将高差转化为数字类型 ： string -> double
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                pointHidList[i] = Convert.ToDouble(_pointHidList[i]);
                sum += pointHidList[i];
            }

            //获取闭合差
            double Correction = sum / n;

            //获取各点的实际高程
            double[] Hid = new double[n];
            Hid[0] = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)//最后一段高差不用算，所以循环范围为0-n-2
            {
                Hid[i + 1] = Hid[i] + pointHidList[i] - Correction;
            }
            //输出
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{pointNameList[i]}点的高程为{Hid[i]:F3}");
            }
            Console.WriteLine($"高差闭合差为{sum:F3}\n改正数为{-Correction:F3}");


        }
    }
}
