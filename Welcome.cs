using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EnterName f5 = new EnterName();
            f5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToDo TD = new ToDo();
            this.Hide();
            TD.Show();
            this.Close();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
