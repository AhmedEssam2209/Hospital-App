using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class SetSalaries : Form
    {
        Controller cont;
        int selection;
        public SetSalaries()
        {
            InitializeComponent();
            cont = new Controller();
            selection = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selection = 1;
            DataTable dt = cont.SelectAllDoctors();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "FName";
            comboBox1.ValueMember = "DoctorID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selection = 2;
            DataTable dt = cont.SelectAllNurses();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "FName";
            comboBox1.ValueMember = "NurseID";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selection == 1)
            {
                textBox2.Text = cont.SelectDoctorSalary(Convert.ToInt32(comboBox1.SelectedValue)).ToString();
                DataTable dt = cont.SelectDoctorFeedback(Convert.ToInt32(comboBox1.SelectedValue)); ;
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else if (selection == 2)
            {
                textBox2.Text = cont.SelectNurseSalary(Convert.ToInt32(comboBox1.SelectedValue)).ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selection == 1)
            {
                int i = cont.UpdateDocSalary(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToDecimal(textBox1.Text));
                MessageBox.Show("Salary Updated successfully");

            }
            else if (selection == 2)
            {
                int i = cont.UpdateNurseSalary(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToDecimal(textBox1.Text));
                MessageBox.Show("Salary Updated successfully");

            }
        }
    }
}
