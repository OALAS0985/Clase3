using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase3
{
    public partial class Form1 : Form
    {
        bool cond = false;
        int i = 35;
        int[] myints = { 5, 10, 15 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int myTest = 2;
            cond = true;
            if (cond == true)
            {
                textBox1.Text = "Hello world and Oscar ";
                textBox2.Text = Convert.ToString(i);
                textBox3.Text = Convert.ToString(myints[0]) + " " + Convert.ToString(myints[1]) + " " + Convert.ToString(myints[2]);
            }
            // if (myTest==1)
            // {
            //     MessageBox.Show("hello 1");
            // }
            // else if (myTest == 2)
            // {
            //     MessageBox.Show("hello 2");
            // }
            //else 
            // {
            //     MessageBox.Show("hello 3");
            // }
        }
    }
}
