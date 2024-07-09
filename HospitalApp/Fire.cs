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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalApp
{
    public partial class Fire : Form
    {
        Controller cont;
        int selected;
        public Fire()
        {
            InitializeComponent();
            cont = new Controller();
            selected = 1;
            DataTable dt = cont.SelectAllDoctors();
            dataGridView1.DataSource = dt;
            comboBox1.DataSource = dt;
            dataGridView1.Refresh();
            comboBox1.DisplayMember = "FName";
            comboBox1.ValueMember = "DoctorID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected = 1;
            DataTable dt = cont.SelectAllDoctors();
            dataGridView1.DataSource = dt;
            comboBox1.DataSource = dt;
            dataGridView1.Refresh();
            comboBox1.DisplayMember = "FName";
            comboBox1.ValueMember = "DoctorID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selected = 2;
            DataTable dt = cont.SelectAllNurses();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            comboBox1.DisplayMember = "FName";
            comboBox1.ValueMember = "NurseID";
            comboBox1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
                int i = cont.DeleteDoctor(Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("Doctor Deleted succesfully");
                return;
            }
            else if (selected == 2)
            {
                int i = cont.DeleteNurse(Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("Nurse Deleted succesfully");

            }

        }
    }
}
