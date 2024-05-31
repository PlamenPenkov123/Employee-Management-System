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
    public partial class FireForm : Form
    {
        List<Employee> employees = new List<Employee>();
        public FireForm()
        {
            InitializeComponent();
        }

        private void FireForm_Load(object sender, EventArgs e)
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

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to fire this person?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
