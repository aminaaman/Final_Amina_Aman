using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        Button[] btns = new Button[9];
        public Form1()
        {

            InitializeComponent();
            btns[0] = button1;
            btns[1] = button2;

            btns[2] = button3;
            btns[3] = button4;

            btns[4] = button5;
            btns[5] = button6;
            btns[6] = button7;
            btns[7] = button8;
            btns[8] = button9;
      
            

            foreach (Button b in btns)
            {
                b.BackColor = Color.Gray;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button_Click(object sender, EventArgs e)
        {
            foreach (Button b in btns)
            {
                if (b.BackColor == Color.Red)
                {
                    b.BackColor = Color.Gray;
                }
            }
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            textBox1.Text += 1;
            textBox1.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

