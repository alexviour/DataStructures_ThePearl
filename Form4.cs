using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static DataStructures.Form5;

namespace DataStructures
{
    public partial class Form4 : Form
    {
        private Queue<string> userQueue = new Queue<string>();

        public string SharedValue { get; set; }

        public Form4()
        {
            InitializeComponent();
            listBox1.Items.Clear();

            listBox1.Items.Add("Nazzer Damiao");
            listBox1.Items.Add("Ma. Lourdes Alexandra Reyes");
            listBox1.Items.Add("Joel Bueno");
            listBox1.Items.Add("Mhia Legal");
            listBox1.Items.Add("Noemi Alon");
            listBox1.Items.Add("Aeron Caballes");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

