using Course_Project.Action_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Course_Project
{
    public partial class MainForm : Form
    {
        List<Employee> employees = new List<Employee>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("employee.json"))
                {
                    string employeeInfo = sr.ReadToEnd();
                    employees = JsonSerializer.Deserialize<List<Employee>>(employeeInfo);
                }

                listBox1.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HireForm hireForm = new HireForm();

            if (hireForm.ShowDialog() == DialogResult.OK)
            {
                // Here it will add the data from the "HireForm".

                Employee employee = new Employee();

                employee.EGN = hireForm.txtBoxEGN.Text;
                employee.FirstName = hireForm.txtBoxFirstName.Text;
                employee.MiddleName = hireForm.txtBoxMiddleName.Text;
                employee.LastName = hireForm.txtBoxLastName.Text;
                employee.Profession = hireForm.comboBoxProfession.Text;
                employee.Department = hireForm.comboBoxDepartment.Text;
                employee.Salary = decimal.Parse(hireForm.txtBoxSalary.Text);
                employee.StartDate = DateTime.Parse(hireForm.dateTimePicker.Text);

                employees.Add(employee);
                listBox1.DataSource = null;
                listBox1.DataSource = employees;

                using (StreamWriter sw = new StreamWriter("employee.json"))
                {
                    string employeeInfo = JsonSerializer.Serialize(employees);
                    sw.WriteLine(employeeInfo);
                }
            }
        }

        private void changeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryForm salaryForm = new SalaryForm();
            if (salaryForm.ShowDialog() == DialogResult.OK)
            {
                // Here we will be changing the salary of a person
                // in the database by finding them using their EGN
                foreach (Employee employee in employees)
                {
                    if (employee.EGN == salaryForm.txtBoxSearchByEGN.Text)
                    {
                        employee.Salary = decimal.Parse(salaryForm.txtBoxSalary.Text);

                        using (StreamWriter sw = new StreamWriter("employee.json"))
                        {
                            string employeeInfo = JsonSerializer.Serialize(employees);
                            sw.WriteLine(employeeInfo);
                        }
                        
                        listBox1.DataSource = null;
                        listBox1.DataSource = employees;
                        break;
                    }
                }
            }
        }

        private void fireEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FireForm fireForm = new FireForm();
            if (fireForm.ShowDialog() == DialogResult.OK)
            {
                // Here we will be firing a person
                // by finding them using their EGN

                foreach (Employee employee in employees)
                {
                    if (employee.EGN == fireForm.txtBoxSearchByEGN.Text)
                    {
                        employees.Remove(employee);

                        using (StreamWriter sw = new StreamWriter("employee.json"))
                        {
                            string employeeInfo = JsonSerializer.Serialize(employees);
                            sw.WriteLine(employeeInfo);
                        }

                        listBox1.DataSource = null;
                        listBox1.DataSource = employees;
                        break;
                    }
                }
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was made by PLAMEN PENKOV\nStudent ID: 2301681046",
                            "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
