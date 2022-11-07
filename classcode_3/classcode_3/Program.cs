using System;

namespace classcode_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入转换方式\ntips:0为弧度转角度,1为角度转弧度");
            string tp = Console.ReadLine();
            Func test = new Func();
            
            if(tp == "1")
            {
                Console.WriteLine("请输入角度(dd.mmss格式):");
                string dms = Console.ReadLine();
                Console.WriteLine( "转换的弧度为{0:F6}",test.DMS2Hu(Convert.ToDouble(dms)));

            }
            else
            {
                Console.WriteLine("请输入弧度：");
                string hu = Console.ReadLine();
                Console.WriteLine("转换的角度为{0:F6}(dd.mmss格式)",test.Hu2DMS(Convert.ToDouble(hu)));
            }
            Console.ReadKey();

        }
    }

    class Func//基础转化函数
    {

        // DMS转弧度
        public double DMS2Hu(double dms)
        {
            int d, m;
            double s;
            d = (int)Math.Floor(dms);
            m = (int)Math.Floor((dms - d) * 100);
            s = ((dms - d) * 100 - m) * 100;
            return DMS2Hu(d, m, s);
        }
        // DMS转弧度
        public double DMS2Hu(int d, int m, double s)
        {
            double val;
            val = (d + m / 60.0 + s / 3600.0) * Math.PI / 180;
            return val;
        }

        // 弧度转度分秒,以dd.mmss表示
        public double Hu2DMS(double hu)
        {
            double d10 = Math.Abs(hu) * 180 / Math.PI; // 十进制度
            int d, m;
            double s;

            d = (int)Math.Floor(d10);
            m = (int)Math.Floor((d10 - d) * 60);
            s = ((d10 - d) * 60 - m) * 60;
            double val = Convert.ToDouble(d.ToString() + "." + m.ToString("00") + s.ToString().Replace(".", ""));
            if (hu < 0) val = -val;
            return val;
        }
        // 计算两点距离
        public double DistAB(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        // 计算方位角
        public double DirectAB(double x1, double y1, double x2, double y2)
        {
            double directVal = Math.Atan2(y2 - y1, x2 - x1);
            if (directVal < 0) directVal += Math.PI * 2;
            return directVal;
        }
    }
}
