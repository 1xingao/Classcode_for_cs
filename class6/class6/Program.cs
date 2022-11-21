using System;
using System.Collections.Generic;
using System.Linq;

namespace class6
{
    class student
    {
        public int grade;
        public string name;
        public student(int _grade, string _name)
        {
            grade = _grade;
            name = _name;
        }
    };


    class Program
    {
        static void Main(string[] args)
        {
            Soluation(); //方法一

        }

        /// <summary>
        /// 方法二
        /// </summary>
        static void Soluation2()
        {
            List<student> stu = new List<student>();
            Program Func = new Program();
            System.Random ran = new System.Random();
            var Name_List = Func.GetName();
            int n = 58;
            for (int i = 0; i < n; i++)
            {
                stu.Add(new student(ran.Next(50, 101), Name_List[i]));
            }

            qsort(ref stu);
            for (int i = 0; i < 58; i++)
            {
                Console.WriteLine($"{stu[i].name}的成绩为{stu[i].grade}");
            }
            
            Console.ReadKey();

        }
        //冒泡排序
        private static void qsort(ref List<student> stu)
        {
            for (int i = 0; i < 58; i++)
            {
                for (int j = 0; j < 58; j++)
                {
                    if (stu[i].grade > stu[j].grade)
                    {
                        var temp = stu[i];
                        stu[i] = stu[j];
                        stu[j] = temp;
                    }
                }
            }
        }
        static void Soluation()
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
                #region .
                if (Name_List[i] == "邢骜") { Name_List[i] += "(这是我，哎嘿)"; }
                if (Name_List[i] == "袁嘉琳") { Name_List[i] += "(这是我的倒霉室友)"; }
                #endregion .
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
                if (next < 5)
                {
                    Fif_List[next] = value.Key;
                }
                next++;
                if (next == 58) { Console.WriteLine("\n\n" + value + "这个小伙子水平有点低啊"); break; }
                Console.Write(value + " -------  ");
                if (next % 3 == 0) { Console.Write("\n"); }
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
            Console.WriteLine("tips:随机生成的似乎不符合正态分布吧 / > _ ^（哎嘿）\n");
            Console.WriteLine("成绩的前五名为:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{Fif_List[i]}成绩为{dict[Fif_List[i]]}");
            }
            Console.WriteLine($"优秀率为{(A / 58.0) * 100:F3}%");
            Console.ReadKey();
        }
        //生成名字列表
        private string[] GetName()
        {
            string[] xing = new string[8] { "邢", "谢", "袁", "张", "陶", "杨", "蔡", "胡" };
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
