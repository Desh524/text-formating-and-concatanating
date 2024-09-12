using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* Pen blackpen = new Pen(Color.Black,5);
        int x1 = 100, y1 = 100, x2 = 500, y2 = 100;
        e.Graphics.DrawLine(blackpen,x1,y1,x2,y2);
        */




        /*private void mousePos_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos.Text = String.Format("({0}, {1})", e.X, e.Y);
        }
        */
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblDanger_Click(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            string[] names = {"Amal","Kamal", "Namal", "teena", "meena", "tania" };
            //for (int i = 0; i < names.Length; i++) {
            int[] num = { 10,20,30,40,50,60,70,80,90,100};
            foreach (int i in num) {
                
            liboxname.Items.Add(i);
            }
            
        }*/

        private void mousePos_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = txtplain.Text;
            txtconvrt.Text = a.ToUpper();
            txtlower.Text = a.ToLower();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtconvrt.Text = "";
            txtplain.Text = "";
            txtlower.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = txtfirst.Text;
            string b = txtsecnd.Text;

            txtconct.Text = string.Concat(a," "+ b);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtfirst.Text = "";
            txtsecnd.Text = "";
            txtconct.Text = "";
        }
    }
}
