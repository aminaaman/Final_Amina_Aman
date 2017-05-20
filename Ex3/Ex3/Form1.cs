using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        Label[] lbls = new Label[12]; 
        public Form1()
        {
            InitializeComponent();
            lbls[0] = label1;
            lbls[1] = label2;
            lbls[2] = label3;
            lbls[3] = label4;
            lbls[4] = label5;
            lbls[5] = label6;
            lbls[6] = label7;
            lbls[7] = label8;
            lbls[8] = label9;
            lbls[9] = label10;
            lbls[10] = label11;
            lbls[11] = label12;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (Label l in lbls)
            {
                if (l.ForeColor == Color.Red)
                {
                    l.ForeColor = Color.Black;
                }
                
            }
            for (int i = 0; i < lbls.Length; i++)
            {
                lbls[i].ForeColor = Color.Red;
                i++;
                Refresh();
            }

                       
            
        }
    }
}
