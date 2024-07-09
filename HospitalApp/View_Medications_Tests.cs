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
    public partial class View_Medications_Tests : Form
    {
        Controller controllerObj;
        public View_Medications_Tests()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }



        private void GetTests_button_Click(object sender, EventArgs e)
        {
            if (EnterpatientSSN_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Your ID");

            }
            else
            {
                DataTable dt = controllerObj.SelectTests(Convert.ToInt16(GetPatId_button.Text));
                GetTests_dataGridView.DataSource = dt;
                GetTests_dataGridView.Refresh();
            }
        }

        private void ViewMedications_button_Click(object sender, EventArgs e)
        {
            if (EnterpatientSSN_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Your ID");
            }
            else
            {
                DataTable dt = controllerObj.SelectMedications(Convert.ToInt16(PatID_textBox.Text));
                GetMed_dataGridView.DataSource = dt;
                GetMed_dataGridView.Refresh();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetTests_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Medications_Tests_Load(object sender, EventArgs e)
        {

        }

        private void EnterpatientSSN_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetPatId_button_Click(object sender, EventArgs e)
        {
            if (EnterpatientSSN_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Your SSN");
            }
            else
            {
                PatID_textBox.Text = controllerObj.GetPatientID(Convert.ToInt16(EnterpatientSSN_textBox.Text)).ToString();

            }
        }
    }
}
