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
    public partial class Employee : Form
    {
        private List<Employees> employees;

        public Employee()
        {
            InitializeComponent();
            InitializeEmployees();
            InitializeComboBox();
        }

        private void InitializeEmployees()
        {
            employees = new List<Employees>
            {
            new Employees { Name = "Aeron", Expertise = new HashSet<string> { "Event Management", "Customer Support", "Logistics" } },
            new Employees { Name = "Nazzer", Expertise = new HashSet<string> { "Event Management", "Marketing", "Customer Support" } },
            new Employees { Name = "Mhia", Expertise = new HashSet<string> { "Event Management", "Technical Support", "Customer Support" } },
            new Employees { Name = "Joel", Expertise = new HashSet<string> { "Event Management", "Marketing", "Branding" } },
            new Employees { Name = "Noemi", Expertise = new HashSet<string> { "Event Management", "Financial Management", "Budgeting" } },
            new Employees { Name = "Alex", Expertise = new HashSet<string> { "Event Management", "Design", "Branding" } }
            };
        }

        private void InitializeComboBox()
        {
            comboBoxExpertise.Items.Add("Event Management");
            comboBoxExpertise.Items.Add("Customer Support");
            comboBoxExpertise.Items.Add("Logistics");
            comboBoxExpertise.Items.Add("Marketing");
            comboBoxExpertise.Items.Add("Technical Support");
            comboBoxExpertise.Items.Add("Branding");
            comboBoxExpertise.Items.Add("Financial Management");
            comboBoxExpertise.Items.Add("Budgeting");
            comboBoxExpertise.Items.Add("Design");

            comboBoxExpertise.SelectedIndex = 0;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DisplayEmployees(employees);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedExpertise = comboBoxExpertise.SelectedItem.ToString();
            var filteredEmployees = employees.Where(emp => emp.Expertise.Contains(selectedExpertise)).ToList();
            DisplayEmployees(filteredEmployees);
        }

        private void DisplayEmployees(List<Employees> employeeList)
        {
            dgvEmployees.Rows.Clear();
            foreach (var employee in employeeList)
            {
                dgvEmployees.Rows.Add(employee.Name, string.Join(", ", employee.Expertise));
            }
        }
    }
}

public class Employees
{
    public string Name { get; set; }
    public HashSet<string> Expertise { get; set; } = new HashSet<string>();
}