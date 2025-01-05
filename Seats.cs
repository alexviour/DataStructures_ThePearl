using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class Seats : Form
    {
        private readonly Queue<string> _userQueue = new Queue<string>();
        private readonly List<TreeNode> _seatingTree = new List<TreeNode>();

        public string SharedValue { get; set; }

        public Seats()
        {
            InitializeComponent();
            InitializeUserList();
            InitializeSeatingTree();
        }

        private void InitializeUserList()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new string[]
            {
                "Nazzer Damiao",
                "Ma. Lourdes Alexandra Reyes",
                "Joel Bueno",
                "Mhia Legal",
                "Noemi Alon",
                "Aeron Caballes"
            });
        }

        private void InitializeSeatingTree()
        {
            int rowCount = 5;
            int seatsPerRow = 6;
            int seatNumber = 1;

            for (int row = 1; row <= rowCount; row++)
            {
                var treeRow = new TreeNode(row);

                for (int seat = 1; seat <= seatsPerRow; seat++)
                {
                    Button seatButton = FindSeatButton(seatNumber);
                    if (seatButton != null)
                    {
                        var seatNode = new SeatNode(seatNumber, seatButton);
                        treeRow.Seats.Add(seatNode);
                    }
                    seatNumber++;
                }

                _seatingTree.Add(treeRow);
            }
        }

        private Button FindSeatButton(int seatNumber)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button && button.Tag?.ToString() == $"Seat{seatNumber}")
                {
                    return button;
                }
            }
            return null;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Welcome form1 = new Welcome();
            form1.Show();
            Hide();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAttendee = listBox1.SelectedItem.ToString();
                MessageBox.Show($"Selected attendee: {selectedAttendee}");
            }
        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            // Example action for seat reservation
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }

    public class TreeNode
    {
        public int RowNumber { get; set; }
        public List<SeatNode> Seats { get; set; }

        public TreeNode(int rowNumber)
        {
            RowNumber = rowNumber;
            Seats = new List<SeatNode>();
        }
    }

    public class SeatNode
    {
        public int SeatNumber { get; set; }
        public Button SeatButton { get; set; }
        public bool IsReserved { get; set; }

        public SeatNode(int seatNumber, Button seatButton)
        {
            SeatNumber = seatNumber;
            SeatButton = seatButton;
            IsReserved = false;

            SeatButton.BackColor = Color.LightGray;
            SeatButton.Click += (s, e) => ReserveSeat();
        }

        public void ReserveSeat()
        {
            if (!IsReserved)
            {
                IsReserved = true;
                SeatButton.BackColor = Color.Pink;
                MessageBox.Show($"Seat {SeatNumber} has been reserved!");
            }
            else
            {
                MessageBox.Show($"Seat {SeatNumber} is already reserved!");
            }
        }
    }
}
