using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7forMatrix
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择需要的功能：\n1.求和、\n2.求乘积 \n3.求逆");
            string temp = Console.ReadLine();
            if(temp == "1")
            {
                Calc.SumMat();
            }else if(temp == "2")
            {
                Calc.multiplyMat();
            }else
            {
                Calc.Inverse();
            }
            Console.ReadKey();
        }
    }
    //实际执行运算的静态类库
    static class Calc
    {
        //获取矩阵数据
        private static double[] GetDouble(string[] data)
        {
            double[] res = new double[data.Length];
            for(int i = 0; i < data.Length; i++)
            {
                res[i] = Convert.ToDouble(data[i]);
            }
            return res;
        }
        //将数据转化为浮点数数组，输入为字符串数组
        private static double[] GetMatData()
        {
            
            Console.WriteLine("请输入矩阵数据");
            string[] data = Console.ReadLine().Split(',');
            var double_data = GetDouble(data);
            return double_data;
        }
        //转置
        public static void Inverse()
        {
            Console.WriteLine("请输入矩阵1的行数和列数:tips:(3,3)");
            string[] res = Console.ReadLine().Split(',');
            double[] data = GetMatData();
            Matrix mat1 = new Matrix(data,Convert.ToInt32(res[0]), Convert.ToInt32(res[1]));
            if(res[0] != res[1])
            {
                Console.WriteLine("不是方阵无法求逆");
                return;
            }
            Console.WriteLine("求逆后的矩阵为：");
            Print(mat1.Inverse());
        }
        //求乘积
        public static void multiplyMat()
        {
            Console.WriteLine("请输入矩阵1的行数和列数:tips:(3,3)");
            string[] res = Console.ReadLine().Split(',');
            double[] data1 = GetMatData();
            Matrix mat1 = new Matrix(data1,Convert.ToInt32(res[0]), Convert.ToInt32(res[1]));
            Console.WriteLine("请输入矩阵2的行数和列数:tips:(3,3)");
            string[] res2 = Console.ReadLine().Split(',');
            double[] data2 = GetMatData();
            Matrix mat2 = new Matrix(data2,Convert.ToInt32(res2[0]), Convert.ToInt32(res2[1]));
            if (res[0] != res2[1] )
            {
                Console.WriteLine("行列数不匹配，无法乘法");
                return;
            }
            Matrix ret = mat1 * mat2;
            Console.WriteLine($"mat1的数据为:");
            Print(mat1);
            Console.WriteLine($"mat2的数据为:");
            Print(mat2);
            Console.WriteLine($"乘法后的数据为:");
            Print(ret);
        }
        //求和
        public static void SumMat()
        {
            Console.WriteLine("请输入矩阵1的行数和列数:tips:(3,3)");
            string[] res = Console.ReadLine().Split(',');
            double[] data1 = GetMatData();
            Matrix mat1 = new Matrix(data1,Convert.ToInt32(res[0]), Convert.ToInt32(res[1]));
            Console.WriteLine("请输入矩阵2的行数和列数:tips:(3,3)");
            string[] res2 = Console.ReadLine().Split(',');
            double[] data2 = GetMatData();
            Matrix mat2 = new Matrix(data2,Convert.ToInt32(res2[0]), Convert.ToInt32(res2[1]));
            if(res[0]!=res2[0] || res[1] != res2[1])
            {
                Console.WriteLine("行列数不匹配，无法加法");
                return;
            }
            Matrix ret = mat1 + mat2;
            Console.WriteLine($"mat1的数据为:");
            Print(mat1);
            Console.WriteLine($"mat2的数据为:");
            Print(mat2);
            Console.WriteLine($"求和后的数据为:");
            Print(ret);
        }
        //矩阵数据的格式化输出
        private static void Print(Matrix mat)
        {
            
            for (int i = 0; i < mat.Row; i++)
            {
                for (int j = 0; j < mat.Col; j++)
                {
                    
                    Console.Write("| "+ mat[i, j]);
                }
                Console.Write("  |\n");
            }
        }
    }
}
