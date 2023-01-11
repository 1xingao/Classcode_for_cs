using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetPassWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            if(textBox1.Text != "")
            {
                try
                {
                    if (comboBox1.SelectedIndex == 0) // 二进制
                    {
                        Func(2);
                    }
                    else if (comboBox1.SelectedIndex == 1) //十进制
                    {
                        Func(10);
                    }
                    else if (comboBox1.SelectedIndex == 3) //八进制
                    {
                        Func(8);
                    }
                    else //十六进制
                    {
                        Func(16);
                    }
                }
                catch
                {
                    textBox1.Text = "输入数据不正确或者进制过大";
                    return;
                }
            }
        }
        /// <summary>
        /// 执行转换函数
        /// </summary>
        /// <param name="n"></param>
        private void Func(int n)
        {
            string sh;
            if (n==16&&textBox1.Text.StartsWith("0x"))
            {
                sh = textBox1.Text.Substring(2);
            }
            else
            {
                sh = textBox1.Text;
            }
            int res = Convert.ToInt32(sh, n);

            textBox4.Text = Convert.ToString(res);
            textBox3.Text = Convert.ToString(res, 16);
            textBox2.Text = Convert.ToString(res, 2);
            textBox10.Text = Convert.ToString(res, 8);

            if (textBox11.Text != "n进制" && textBox11.Text != "" )
            {
                int nu = Convert.ToInt32(textBox11.Text);
                if (nu <= 1 && n > 36)
                {
                    textBox1.Text = "进制不正确";
                    return;
                }
                textBox12.Text = Dtox(res,nu);
            }
        }
        /// <summary>
        /// 十进制转化为任意进制
        /// </summary>
        /// <param name="digital"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private string Dtox(int digital, int r)
        {
            string result = "";
            const string s = "0123456789abcdefghijklmnopqrstuvwxyz";
            if (digital == 0)
            {
                return "0";
            }
            while (digital != 0)
            {
                int tmp = digital % r;
                result += s[tmp];
                digital /= r;
            }
            char[] ch = result.ToCharArray();
            Array.Reverse(ch);
            result = "";
            foreach (char c in ch)
            {
                result += c;
            }
            return result;
        }
        
    }
}
