using System;
using System.Collections.Generic;
using System.Text;

namespace class_code_1
{
    class Altitude
    {
        string name1 ;
        string name2 ;
        double KnownPoint = 0, UnknownPoint = 0;
        double HeightDifference = 0;
       
        /// <summary>
        /// 类内初始化
        /// </summary>
        /// <param name="_name1"></param>
        /// <param name="_name2"></param>
        /// <param name="_knownPoint"></param>
        /// <param name="_HeightDifference"></param>
        public Altitude(string _name1,string _name2,double _knownPoint,double _HeightDifference)
        {
            this.name1 = _name1;
            this.name2 = _name2;
            this.KnownPoint = _knownPoint;
            this.HeightDifference = _HeightDifference;
        }
        /// <summary>
        /// 计算函数
        /// </summary>
        /// <returns></returns>
        public double Calc ()
        {
            this.UnknownPoint = KnownPoint + HeightDifference;
            return this.UnknownPoint;
        }
        /// <summary>
        /// 格式化输出
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"已知点{name1}的高程为{KnownPoint}");
            Console.WriteLine($"未知点{name2}的高程为{UnknownPoint}");
            Console.WriteLine($"二者高差为{HeightDifference}");
        }
    }
}
