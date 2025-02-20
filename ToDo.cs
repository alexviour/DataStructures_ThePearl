﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class ToDo : Form
    {
        public Stack<string> stack;

        public ToDo()
        {
            InitializeComponent();
            stack = new Stack<string>();
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            PushToStack();
        }

        private void updateStack()
        {
            listBox1.Items.Clear();
            foreach (string item in stack)
            {
                listBox1.Items.Add($"❑ {item}");
            }
        }

        private void PushToStack()
        {
            string value = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                stack.Push(value);
                updateStack();
                textBox1.Clear();
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PushToStack();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                string poppedValue = stack.Pop();
                updateStack();
                listBox2.Items.Add($"✔️ {poppedValue}");
            }
            else
            {
                MessageBox.Show("All tasks are finished.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                string lastValue = listBox2.Items[listBox2.Items.Count - 1].ToString().Substring(2);
                listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
                stack.Push(lastValue);
                updateStack();
            }
            else
            {
                MessageBox.Show("There's no tasks to redo.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Welcome f1 = new Welcome();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            this.Hide();
            employee.Show();
            this.Close();
        }
    }
}