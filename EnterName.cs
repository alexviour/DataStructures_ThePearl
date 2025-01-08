using System;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class EnterName : Form
    {
        public static string UserName;

        public EnterName()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserName = txtName.Text;
            Eventlist F3 = new Eventlist();
            this.Hide();
            F3.Show();
            this.Close();
        }
    }
}