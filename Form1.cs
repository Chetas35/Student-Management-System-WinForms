using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagmentSys
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
               string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtDept.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            Student s = new Student();
            s.StudentId = int.Parse(txtId.Text);
            s.Name = txtName.Text;
            s.Department = txtDept.Text;

            students.Add(s);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;

            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtDept.Clear();
            txtId.Focus();
        }
    }
}
