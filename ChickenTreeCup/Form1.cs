using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace chicken_tree_cup
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public int fenshu = 0;
        //结局
        public string[] jieju_text_arr = { "骑士", "蒂蒂", "锈锤", "寒灾", "墓碑" };
        public string jieju_text = ""; 
        public bool[] jieju = { false, false, false, false, false };
        //道中加分
        public int[] daozhong = { 0, 0, 0, 0, 0 };
        //特殊关卡
        public string[] teshu_text_arr = { "领地意识80", "狩猎场60", "失控120", "育生池90", "好梦在何方90", "机械之灾50", "水火相容150", "深度认知80", "真相通关50", "真相无漏100", "狂信如火无漏50", "跳舞通关50", "跳舞无漏+箱子全收100", "鸭本通关80", "监工现场杀鸭30" };
        public string teshu_text = "";
        public bool[] teshu = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

        private void Refresh_jieju()
        {
            jieju_text = "";
            for (int i = 0; i < 5; i++)
            {
                if (jieju[i])
                {
                    jieju_text += jieju_text_arr[i]+" ";
                    
                }
            }
            label5.Text = jieju_text;
        }
        private void Refresh_daozhong()
        {
            label8.Text = daozhong[0].ToString();
            label14.Text = daozhong[1].ToString();
            label10.Text = daozhong[2].ToString();
            label16.Text = daozhong[3].ToString();
            label12.Text = daozhong[4].ToString();
        }
        private void Refresh_teshu()
        {
            //还买开始写
            //
            //Console.WriteLine(xianshi_fenshu);
            teshu_text = "";
            for (int i = 0; i < 15; i++)
            {
                if (teshu[i])
                {
                    teshu_text += teshu_text_arr[i] + " ";
                }
            }
            label22.Text = teshu_text;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            daozhong[0] += 1;
            fenshu += 50;
            Refresh_daozhong();
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jieju[0] == false)
            {
                jieju[0] = true;
                fenshu += 450;
            }
            else
            {
                fenshu -= 450;
                jieju[0] = false;
            }
            Refresh_jieju();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jieju[1] == false)
            {
                jieju[1] = true;
                fenshu += 80;
            }
            else
            {
                fenshu -= 80;
                jieju[1] = false;
            }
            Refresh_jieju();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jieju[2] == false)
            {
                jieju[2] = true;
                fenshu += 120;
            }
            else
            {
                fenshu -= 120;
                jieju[2] = false;
            }
            Refresh_jieju();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jieju[3] == false)
            {
                jieju[3] = true;
                fenshu += 150;
            }
            else
            {
                fenshu -= 150;
                jieju[3] = false;
            }
            Refresh_jieju();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jieju[4] == false)
            {
                jieju[4] = true;
                fenshu += 230;
            }
            else
            {
                fenshu -= 230;
                jieju[4] = false;
            }
            Refresh_jieju();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            daozhong[0] -= 1;
            fenshu -= 50;
            Refresh_daozhong();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            daozhong[1] += 1;
            fenshu += 20;
            Refresh_daozhong();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            daozhong[1] -= 1;
            fenshu -= 20;
            Refresh_daozhong();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            daozhong[2] += 1;
            fenshu += 10;
            Refresh_daozhong();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            daozhong[2] -= 1;
            fenshu -= 10;
            Refresh_daozhong();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            daozhong[3] += 1;
            fenshu += 20;
            Refresh_daozhong();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            daozhong[3] -= 1;
            fenshu -= 20;
            Refresh_daozhong();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            daozhong[4] += 1;
            fenshu += 25;
            Refresh_daozhong();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            daozhong[4] -= 1;
            fenshu -= 25;
            Refresh_daozhong();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (teshu[0] == false)
            {
                fenshu += 80;
                teshu[0] = true;
            }
            else
            {
                fenshu -= 80;
                teshu[0] = false;
            }
            Refresh_teshu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (teshu[1] == false)
            {
                fenshu += 60;
                teshu[1] = true;
            }
            else
            {
                fenshu -= 60;
                teshu[1] = false;
            }
            Refresh_teshu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (teshu[2] == false)
            {
                fenshu += 120;
                teshu[2] = true;
            }
            else
            {
                fenshu -= 120;
                teshu[2] = false;
            }
            Refresh_teshu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (teshu[3] == false)
            {
                fenshu += 90;
                teshu[3] = true;
            }
            else
            {
                fenshu -= 90;
                teshu[3] = false;
            }
            Refresh_teshu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (teshu[4] == false)
            {
                fenshu += 90;
                teshu[4] = true;
            }
            else
            {
                fenshu -= 90;
                teshu[4] = false;
            }
            Refresh_teshu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (teshu[5] == false)
            {
                fenshu += 50;
                teshu[5] = true;
            }
            else
            {
                fenshu -= 50;
                teshu[5] = false;
            }
            Refresh_teshu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (teshu[6] == false)
            {
                fenshu += 150;
                teshu[6] = true;
            }
            else
            {
                fenshu -= 150;
                teshu[6] = false;
            }
            Refresh_teshu();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (teshu[7] == false)
            {
                fenshu += 80;
                teshu[7] = true;
            }
            else
            {
                fenshu -= 80;
                teshu[7] = false;
            }
            Refresh_teshu();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (teshu[8] == false)
            {
                fenshu += 50;
                teshu[8] = true;
            }
            else
            {
                fenshu -= 50;
                teshu[8] = false;
            }
            Refresh_teshu();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (teshu[9] == false)
            {
                fenshu += 100;
                teshu[9] = true;
            }
            else
            {
                fenshu -= 100;
                teshu[9] = false;
            }
            Refresh_teshu();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (teshu[10] == false)
            {
                fenshu += 50;
                teshu[10] = true;
            }
            else
            {
                fenshu -= 50;
                teshu[10] = false;
            }
            Refresh_teshu();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (teshu[11] == false)
            {
                fenshu += 50;
                teshu[11] = true;
            }
            else
            {
                fenshu -= 50;
                teshu[11] = false;
            }
            Refresh_teshu();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (teshu[12] == false)
            {
                fenshu += 100;
                teshu[12] = true;
            }
            else
            {
                fenshu -= 100;
                teshu[12] = false;
            }
            Refresh_teshu();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            if (teshu[13] == false)
            {
                fenshu += 80;
                teshu[13] = true;
            }
            else
            {
                fenshu -= 80;
                teshu[13] = false;
            }
            Refresh_teshu();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (teshu[14] == false)
            {
                fenshu += 30;
                teshu[14] = true;
            }
            else
            {
                fenshu -= 30;
                teshu[14] = false;
            }
            Refresh_teshu();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int tongguan = 0;
            int cangpin = 0;
            int shanglun = 0;
            if (textBox4.Text != "")
            {
                tongguan = int.Parse(textBox4.Text);
            }
            if (textBox5.Text != "")
            {
                cangpin = int.Parse(textBox5.Text);
            }
            if (textBox6.Text != "")
            {
                shanglun = int.Parse(textBox6.Text);
            }
            double xianshi_fenshu = fenshu + tongguan + cangpin * 10 + shanglun*0.15;
            label23.Text = xianshi_fenshu.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            jieju = new bool[]{ false, false, false, false, false };
            daozhong = new int[]{ 0, 0, 0, 0, 0 };
            teshu = new bool[]{ false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            Refresh_jieju();
            Refresh_daozhong();
            Refresh_teshu();
            textBox4.Text = "";
            textBox5.Text = "";
            label23.Text = "";
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
