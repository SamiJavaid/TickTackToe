using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTackToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool op = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (op)
            {
                button1.Text = "X";
                button1.Enabled = false;
                op = false;
            }
            else
            {
                button1.Text = "O";
                button1.Enabled = false;
                op = true;
            }
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (op)
            {
                button2.Text = "X";
                button2.Enabled = false;
                op = false;
            }
            else
            {
                button2.Text = "O";
                button2.Enabled = false;
                op = true;
            }
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (op)
            {
                button3.Text = "X";
                button3.Enabled = false;
                op = false;
            }
            else
            {
                button3.Text = "O";
                button3.Enabled = false;
                op = true;
            }
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (op)
            {
                button4.Text = "X";
                button4.Enabled = false;
                op = false;
            }
            else
            {
                button4.Text = "O";
                button4.Enabled = false;
                op = true;
            }
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (op)
            {
                button5.Text = "X";
                button5.Enabled = false;
                op = false;
            }
            else
            {
                button5.Text = "O";
                button5.Enabled = false;
                op = true;
            }
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (op)
            {
                button6.Text = "X";
                button6.Enabled = false;
                op = false;
            }
            else
            {
                button6.Text = "O";
                button6.Enabled = false;
                op = true;
            }
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (op)
            {
                button7.Text = "X";
                button7.Enabled = false;
                op = false;
            }
            else
            {
                button7.Text = "O";
                button7.Enabled = false;
                op = true;
            }
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (op)
            {
                button8.Text = "X";
                button8.Enabled = false;
                op = false;
            }
            else
            {
                button8.Text = "O";
                button8.Enabled = false;
                op = true;
            }
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (op)
            {
                button9.Text = "X";
                button9.Enabled = false;
                op = false;
            }
            else
            {
                button9.Text = "O";
                button9.Enabled = false;
                op = true;
            }
            check();
        }
        void check()
        {
            String btn1 = button1.Text;
            String btn2 = button2.Text;
            String btn3 = button3.Text;
            String btn4 = button4.Text;
            String btn5 = button5.Text;
            String btn6 = button6.Text;
            String btn7 = button7.Text;
            String btn8 = button8.Text;
            String btn9 = button9.Text;

            if (btn1 =="X" && btn2=="X" && btn3 == "X")
            {
                MessageBox.Show("X wins ");
            }
            if (btn4 == "X" && btn5 == "X" && btn6 == "X")
            {
                MessageBox.Show("X wins ");
            }
            if (btn7 == "X" && btn8== "X" && btn9 == "X")
            {
                MessageBox.Show("X wins ");
            }
            if (btn1 == "X" && btn4 == "X" && btn7 == "X")
            {
                MessageBox.Show("X wins ");
            }
            if (btn2 == "X" && btn5 == "X" && btn8 == "X")
            {
                MessageBox.Show("X wins ");
            }
            if (btn3 == "X" && btn6 == "X" && btn9 == "X")
            {
                MessageBox.Show("X wins ");
            }
            if (btn1 == "X" && btn5 == "X" && btn9 == "X")
            {
                MessageBox.Show("X wins ");
            }
            if (btn3 == "X" && btn5 == "X" && btn7 == "X")
            {
                MessageBox.Show("X wins ");
            }
            if (btn1 == "O" && btn2 == "O" && btn3 == "O")
            {
                MessageBox.Show("O wins ");
            }
            if (btn4 == "O" && btn5 == "O" && btn6 == "O")
            {
                MessageBox.Show("O wins ");
            }
            if (btn7 == "O" && btn8 == "O" && btn9 == "O")
            {
                MessageBox.Show("O wins ");
            }
            if (btn1 == "O" && btn4 == "O" && btn7 == "O")
            {
                MessageBox.Show("O wins ");
            }
            if (btn2 == "O" && btn5 == "O" && btn8 == "O")
            {
                MessageBox.Show("O wins ");
            }
            if (btn3 == "O" && btn6 == "O" && btn9 == "O")
            {
                MessageBox.Show("O wins ");
            }
            if (btn1 == "O" && btn5 == "O" && btn9 == "O")
            {
                MessageBox.Show("O wins ");
            }
            if (btn3 == "O" && btn5 == "O" && btn7 == "O")
            {
                MessageBox.Show("O wins ");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
        }
    }
}
