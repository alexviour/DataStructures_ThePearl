using System;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class EnterName : Form
    {
        public EnterName()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Eventlist F3 = new Eventlist();
            F3.retainName(name);
            this.Hide();
            F3.Show();
            this.Close();
        }
    }
}
