using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataStructures
{
    public partial class Form3 : Form
    {
        public string UserInputValue { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4 { SharedValue = UserInputValue };
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4 { SharedValue = UserInputValue };
            form4.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4 { SharedValue = UserInputValue };
            form4.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4 { SharedValue = UserInputValue };
            form4.Show();
            this.Hide();
        }
        public void retainName(string name) {
            string Username = name;
        }
    }
}
