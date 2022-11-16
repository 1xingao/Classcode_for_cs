using System;
using System.Collections.Generic;
using System.Linq;

namespace classFor6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Func = new Program();
            System.Random ran = new System.Random();
            int[] grade_list = new int[58];
            int n = 58;
            for (int i = 0; i < n; i++)
            {
                grade_list[i] = ran.Next(50, 101);
            }
            var Name_List = Func.GetName();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            //本身不是红黑树或者哈希表实现可以直接排序
            for (int i = 0; i < 58; i++)
            {
                if(Name_List[i] == "邢骜") { Name_List[i] += "(这是我，哎嘿)"; }
                dict.Add(Name_List[i], grade_list[i]);
            }
            var sortedDict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            //list辅助排序方式cpp写法
            //List<KeyValuePair<string, int>> map = dict.ToList();
            //map.Sort((x, y) => x.Value.CompareTo(y.Value));

            //直接输出方式
            //Console.WriteLine(String.Join(", ", sortedDict));
            string[] Fif_List = new string[5];
            int next = 0;
            Console.WriteLine("全班的成绩为：\n");
            foreach (var value in sortedDict)
            {
                if(next < 5)
                {
                    Fif_List[next++] = value.Key;
                }
                Console.WriteLine(value);
            }


            Console.WriteLine("\n");
            int A = 0, B = 0, C = 0, D = 0, F = 0;
            foreach (var temp in sortedDict)
            {
                if (Func.Getline(temp.Value) == "优秀") { A++; }
                else if (Func.Getline(temp.Value) == "良好") { B++; }
                else if (Func.Getline(temp.Value) == "中等") { C++; }
                else if (Func.Getline(temp.Value) == "及格") { D++; }
                else { F++; }

            }

            Console.WriteLine($"全班共计{n}人\n其中评级为优秀的有{A}人\n其中评级为良好的有{B}人" +
                $"\n其中评级为中等的有{C}人\n其中评级为及格的有{D}人\n其中评级为不及格的有{F}人\n");
            Console.WriteLine("tips:随机生成的似乎不符合正态分布吧  վ'ᴗ' ի（哎嘿）\n");
            Console.WriteLine("成绩的前五名为:");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{Fif_List[i]}成绩为{dict[Fif_List[i]]}");
            }
            Console.ReadKey();

        }
        //生成名字列表
        string[] GetName()
        {
            string[] xing = new string[8] { "邢", "谢", "袁", "张", "陶", "杨", "吴", "胡" };
            string[] name = new string[8] { "嘉琳", "正博", "骜", "欢", "凯夫", "仔怡", "茜", "雨萌" };
            string[] res = new string[58];
            int index = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (index == 58) { break; }
                    res[index++] = xing[i] + name[j];
                }
            }
            return res;
        }
        public string Getline(int grade)
        {

            if (grade > 100 || grade < 0)
            {
                return "成绩不合规范";
            }
            string res;
            switch (grade / 10)
            {
                case 10:
                case 9: res = "优秀"; break;
                case 8: res = "良好"; break;
                case 7: res = "中等"; break;
                case 6: res = "及格"; break;
                default: res = "不及格"; break;
            }
            return res;
        }
    }
}
