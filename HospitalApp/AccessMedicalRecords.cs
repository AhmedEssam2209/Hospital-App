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
    public partial class AccessMedicalRecords : Form
    {
        Controller controllerObj;
        public AccessMedicalRecords()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AccessMedicalRecords_Load(object sender, EventArgs e)
        {

        }

        private void Surgeries_button_Click(object sender, EventArgs e)
        {
            if (PID_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Your Patient ID");
            }
            else
            {
                controllerObj.SelectSurgeries(Convert.ToInt16(PID_textBox.Text));
                DataTable dt = controllerObj.SelectSurgeries(Convert.ToInt16(PID_textBox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void allergies_button_Click(object sender, EventArgs e)
        {
            if (PID_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Your Patient ID");
            }
            else
            {

                controllerObj.SelectAllergies(Convert.ToInt16(PID_textBox.Text));
                DataTable dt = controllerObj.SelectAllergies(Convert.ToInt16(PID_textBox.Text));
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
