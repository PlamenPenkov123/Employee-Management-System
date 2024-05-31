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
    public partial class HireForm : Form
    {
        public HireForm()
        {
            InitializeComponent();
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (txtBoxEGN.Text.Length != 10) flag = false;
            if (txtBoxFirstName.Text == string.Empty) flag = false;
            if (txtBoxMiddleName.Text == string.Empty) flag = false;
            if (txtBoxLastName.Text == string.Empty) flag = false;
            if (comboBoxProfession.Text == string.Empty) flag = false;
            if (comboBoxDepartment.Text == string.Empty) flag = false;
            if (txtBoxSalary.Text == string.Empty) flag = false;
            if (dateTimePicker.Text == string.Empty) flag = false;

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = new StreamReader("employee.json"))
            {
                string stringToCheckEGN = sr.ReadToEnd();
                employees = JsonSerializer.Deserialize<List<Employee>>(stringToCheckEGN);
            }
            foreach (Employee employee in employees)
            {
                if (employee.EGN == txtBoxEGN.Text)
                {
                    flag = false;
                    MessageBox.Show("There already exist an employee with that EGN.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }

            if (flag) DialogResult = DialogResult.OK;
        }

        private void txtBoxEGN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');

            // only allow one decimal point
            e.Handled = (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1);
        }

        private void comboBoxProfession_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
