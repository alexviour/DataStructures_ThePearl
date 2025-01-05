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
    public partial class Eventlist : Form
    {
        public string Username;

        public Eventlist()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome f1 = new Welcome();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToDo f2 = new ToDo();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Seats form4 = new Seats { SharedValue = Username };
            form4.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Seats form4 = new Seats { SharedValue = Username };
            form4.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Seats form4 = new Seats { SharedValue = Username };
            form4.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Seats form4 = new Seats { SharedValue = Username };

            form4.Show();   
            this.Hide();
        }
        public void retainName(string name) {
            this.Username = name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
