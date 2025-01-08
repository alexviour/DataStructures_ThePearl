using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class Seats : Form
    {
        private readonly Queue<string> UserQueue = new Queue<string>();
        public string eventDesc;
        private SeatingTree seatingTree = new SeatingTree();

        public Seats()
        {
            InitializeComponent();
            InitializeSeatingTree();
            AssignSeatClickHandlers();
        }

        private void AssignSeatClickHandlers()
        {
            for (int i = 1; i <= 25; i++)
            {
                PictureBox seatButton = this.Controls.Find($"Seat{i}", true).FirstOrDefault() as PictureBox;

                if (seatButton != null)
                {
                    seatButton.Click += Seat_Click;
                }
            }
        }

        private void InitializeSeatingTree()
        {
            for (int i = 1; i <= 25; i++)
            {
                seatingTree.Insert(i, false);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string fontPath = @"Resources\BalooBhaijaan2-VariableFont_wght.ttf";
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(fontPath);

            label2.Text = eventDesc;
            label2.Font = new Font(pfc.Families[0], 8.25f);

            string[] names = {
            "Alon, Noemi Manlises",
            "Bueno, Joel Coprada",
            "Caballes, Aeron Cedrick Macasaet",
            "Damiao, Lauwrence Nazzer Pundan",
            "Dela Cruz, Ronave Lazo",
            "Dumalag, Ronn Christian Patambang",
            "Laurel, Lanze Jimmrie Maray",
            "Legal, Mhia Paula Eduvije",
            "Magpantay, Benjoe Rebong",
            "Magtipon, Manuel Colcol",
            "Maguyon, Bjorn Marek Serrano",
            "Ormacido, Marck Angelo",
            "Palacio, Kristine Joy San Antoño",
            "Perez, Venedict Rafiñan",
            "Quijioc, Bernadeth Beraquit",
            "Ramos, Jerick Monje",
            "Rapa, John Jubert Demetria",
            "Rayela, Anjeline Babiera",
            "Reyes, Ma. Lourdes Alexandra Freyra",
            "Reyes, Sophia Bianca Flores",
            "Rosales, Shawn Erick Agbada",
            "Salarda, John Jeriazhi Magpantay",
            "Sancon, Mark James Maray",
            "Sanjuan, Jeremie Pahoyo",
            "Sario, Cloe Anne Balmeo",
            "Sayno, Rafael San Gabriel",
            "Suyom, John Kier Marohom",
            "Toledo, Zandra Villaflor",
            "Vergara, Monique Deniel Piol",
            "Vicuña, Sofia Alezandra Grospe",
            "Villapando, Emmanuel Mortel"
        };

            Random random = new Random();
            Queue<string> AttendeeList = new Queue<string>();

            List<int> indices = Enumerable.Range(0, names.Length).ToList();
            indices = indices.OrderBy(_ => random.Next()).ToList();

            for (int i = 0; i <= 10; i++)
            {
                AttendeeList.Enqueue(names[indices[i]]);
            }

            string[] arr = AttendeeList.OfType<string>().ToArray();

            PictureBox[] seats = { Seat1, Seat2, Seat3, Seat4, Seat5, Seat6, Seat7, Seat8, Seat9, Seat10,
                       Seat11, Seat12, Seat13, Seat14, Seat15, Seat16, Seat17, Seat18, Seat19, Seat20,
                       Seat21, Seat22, Seat23, Seat24, Seat25 };

            for (int i = 0; i <= 10; i++)
            {
                try
                {
                    bool updated = seatingTree.UpdateReservation(i, true, arr[i]);
                    dtvAttendeeList.Rows.Add(arr[i]);
                    seats[i].BackgroundImage = Properties.Resources.pinkseat;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void getEventDetails(string eventDesc)
        {
            this.eventDesc = eventDesc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome form1 = new Welcome();
            this.Hide();
            form1.Show();
            this.Close();
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox seatButton = sender as PictureBox;
                if (seatButton == null) return;

                int seatNumber = int.Parse(seatButton.Name.Replace("Seat", ""));

                // Attempt reservation
                bool isReserved = seatingTree.UpdateReservation(seatNumber, true, EnterName.UserName);

                if (isReserved)
                {
                    // Reservation successful
                    seatButton.BackgroundImage = Properties.Resources.pinkseat;
                    dtvAttendeeList.Rows.Add(EnterName.UserName);
                    MessageBox.Show($"Reservation for Seat {seatNumber} made!");
                }
                else
                {
                    MessageBox.Show($"Seat {seatNumber} is already reserved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class TreeNode
        {
            public int SeatNumber { get; set; }
            public bool IsReserved { get; set; }
            public string ReservedBy { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int seatNumber, bool isReserved, string reservedBy = null)
            {
                SeatNumber = seatNumber;
                IsReserved = isReserved;
                ReservedBy = reservedBy;
                Left = null;
                Right = null;
            }
        }

        public class SeatingTree
        {
            public TreeNode Root { get; set; }

            public SeatingTree()
            {
                Root = null;
            }

            public bool UpdateReservation(int seatNumber, bool newStatus, string reservedBy = null)
            {
                TreeNode node = FindNode(Root, seatNumber);

                if (node != null)
                {
                    if (node.IsReserved && newStatus)
                        return false;

                    node.IsReserved = newStatus;
                    node.ReservedBy = newStatus ? reservedBy : null;
                    return true;
                }
                return false; // Node not found
            }

            private TreeNode FindNode(TreeNode current, int seatNumber)
            {
                if (current == null)
                    return null;

                if (current.SeatNumber == seatNumber)
                    return current;

                if (seatNumber < current.SeatNumber)
                    return FindNode(current.Left, seatNumber);

                return FindNode(current.Right, seatNumber);
            }

            public void Insert(int seatNumber, bool isReserved)
            {
                Root = InsertNode(Root, seatNumber, isReserved);
            }

            private TreeNode InsertNode(TreeNode current, int seatNumber, bool isReserved)
            {
                if (current == null)
                    return new TreeNode(seatNumber, isReserved);

                if (seatNumber < current.SeatNumber)
                    current.Left = InsertNode(current.Left, seatNumber, isReserved);
                else if (seatNumber > current.SeatNumber)
                    current.Right = InsertNode(current.Right, seatNumber, isReserved);

                return current;
            }
        }
    }
}