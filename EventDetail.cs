using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class EventDetail : Form
    {
        public string EventTime { get; set; }
        public string EventDescription { get; set; }

        public EventDetail(string eventTime, string eventDescription)
        {
            InitializeComponent();
            EventTime = eventTime;
            EventDescription = eventDescription;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LinkedList<EventDetails> eventDetailsList = new LinkedList<EventDetails>();

            string fontPath = @"Resources\BalooBhaijaan2-VariableFont_wght.ttf";
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(fontPath);

            switch (EventDescription)
            {
                case "Artificial Intelligence Symposium":
                    EventName.Text = EventDescription;
                    EventName.Font = new Font(pfc.Families[0], 21);
                    EventName.Location = new Point((825 - EventName.Width) / 2, 140);
                    eventDetailsList.AddLast(new EventDetails("1:00 PM", "Introduction to AI"));
                    eventDetailsList.AddLast(new EventDetails("2:00 PM", "Machine Learning Trends"));
                    eventDetailsList.AddLast(new EventDetails("3:00 PM", "AI in Robotics"));

                    break;

                case "Cybersecurity Conference":
                    EventName.Text = EventDescription;
                    EventName.Font = new Font(pfc.Families[0], 21);
                    EventName.Location = new Point((825 - EventName.Width) / 2, 140);
                    eventDetailsList.AddLast(new EventDetails("9:00 AM", "Opening Remarks"));
                    eventDetailsList.AddLast(new EventDetails("10:00 AM", "Understanding Cyber Threats"));
                    eventDetailsList.AddLast(new EventDetails("12:00 PM", "Hacking Demonstration"));
                    break;

                case "Machine Learning Seminar":
                    EventName.Text = EventDescription;
                    EventName.Font = new Font(pfc.Families[0], 21);
                    EventName.Location = new Point((825 - EventName.Width) / 2, 140);
                    eventDetailsList.AddLast(new EventDetails("11:00 AM", "Introduction to Machine Learning"));
                    eventDetailsList.AddLast(new EventDetails("1:00 PM", "Supervised Learning"));
                    eventDetailsList.AddLast(new EventDetails("3:00 PM", "Unsupervised Learning"));
                    break;

                case "Web Development Workshop":
                    EventName.Text = EventDescription;
                    EventName.Font = new Font(pfc.Families[0], 21);
                    EventName.Location = new Point((825 - EventName.Width) / 2, 140);
                    eventDetailsList.AddLast(new EventDetails("10:00 AM", "HTML and CSS Basics"));
                    eventDetailsList.AddLast(new EventDetails("12:00 PM", "JavaScript Fundamentals"));
                    eventDetailsList.AddLast(new EventDetails("2:00 PM", "Backend Development with Node.js"));
                    break;

                default:
                    MessageBox.Show("No event details found.");
                    break;
            }

            BindingList<EventDetails> eventDetailsBindingList = ConvertLinkedListToBindingList(eventDetailsList);
            dgvEvents.DataSource = eventDetailsBindingList;
        }

        private BindingList<T> ConvertLinkedListToBindingList<T>(LinkedList<T> linkedList)
        {
            BindingList<T> bindingList = new BindingList<T>();
            foreach (T item in linkedList)
            {
                bindingList.Add(item);
            }
            return bindingList;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Seats seat = new Seats();
            seat.getEventDetails(EventDescription);
            this.Hide();
            seat.Show();
            this.Close();
        }
    }

    public class EventDetails
    {
        public string EventTime { get; set; }
        public string EventDescription { get; set; }

        public EventDetails(string eventTime, string eventDescription)
        {
            EventTime = eventTime;
            EventDescription = eventDescription;
        }
    }
}