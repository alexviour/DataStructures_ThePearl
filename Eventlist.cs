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

        public void retainName(string name) {
            this.Username = name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvEvents.Rows.Add(15, "Artificial Intellligence Symposium");
            dgvEvents.Rows.Add(18, "Cybersecurity Conference");
            dgvEvents.Rows.Add(25, "Machine Learning Seminar");
            dgvEvents.Rows.Add(30, "Web Development Workshop");

        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var eventTime = dgvEvents.Rows[e.RowIndex].Cells[0].Value.ToString(); 
                var eventDescription = dgvEvents.Rows[e.RowIndex].Cells[1].Value.ToString(); 
                EventDetail eventDetails = new EventDetail(eventTime, eventDescription);

                this.Hide();
                eventDetails.Show();
                this.Close();
            }
        }
    }
}
