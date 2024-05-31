using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Project.Action_Forms
{
    public partial class SalaryForm : Form
    {
        List<Employee> employees = new List<Employee>();
        public SalaryForm()
        {
            InitializeComponent();
        }
        private void SalaryForm_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("employee.json"))
            {
                string employeeInfo = sr.ReadToEnd();
                employees = JsonSerializer.Deserialize<List<Employee>>(employeeInfo);
            }
        }
        private void txtBoxSearchByEGN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSearchByEGN_Click(object sender, EventArgs e)
        {
            if (txtBoxSearchByEGN.Text.Length != 10)
            {
                MessageBox.Show("Incorrect Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Employee employee in employees)
                {
                    if (employee.EGN == txtBoxSearchByEGN.Text)
                    {
                        txtBoxFirstName.Text = employee.FirstName;
                        txtBoxMiddleName.Text = employee.MiddleName;
                        txtBoxLastName.Text = employee.LastName;
                        comboBoxProfession.Text = employee.Profession;
                        comboBoxDepartment.Text = employee.Department;
                        txtBoxSalary.Text = employee.Salary.ToString();
                        break;
                    }
                }
            }
        }
        private void btnChangeSalary_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (txtBoxSearchByEGN.Text.Length != 10) flag = false;
            if (txtBoxSalary.Text == string.Empty) flag = false; 
            if (flag) DialogResult = DialogResult.OK;
        }
    }
}
