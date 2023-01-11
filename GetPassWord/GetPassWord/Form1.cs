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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if(comboBox1.SelectedIndex == 0) // 二进制
                {
                    textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2));
                    textBox3.Text = string.Format("{0:x}", Convert.ToInt32(textBox1.Text, 2));
                    textBox2.Text = textBox1.Text;
                }else if (comboBox1.SelectedIndex == 1) //十进制
                {
                    textBox4.Text = textBox1.Text;
                    textBox3.Text = dtox(Convert.ToInt32(textBox1.Text),16);
                    textBox2.Text = dtox(Convert.ToInt32(textBox1.Text), 2);
                }else
                {
                    string sh;
                    if (textBox1.Text.StartsWith("0x"))
                    {
                        sh = textBox1.Text.Substring(2);
                    }
                    else
                    {
                        sh = textBox1.Text;
                    }
                    textBox4.Text = Convert.ToString( Convert.ToInt32(sh, 16));
                    textBox3.Text = sh;
                    textBox2.Text = Convert.ToString(Convert.ToInt32(sh, 16), 2);
                }
            }
        }
        /// <summary>
        /// 十进制转化为任意进制
        /// </summary>
        /// <param name="digital"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        string dtox(int digital, int r)
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
            foreach(char c in ch)
            {
                result += c;
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
