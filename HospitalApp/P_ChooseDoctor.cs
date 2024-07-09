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
    public partial class P_ChooseDoctor : Form
    {
        Controller controllerObj; 
        public P_ChooseDoctor()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.SelectDoctor();
            DrID_comboBox.DisplayMember = "DoctorID";
            DrID_comboBox.ValueMember = "DoctorID";
            DrID_comboBox.DataSource = dt1;
        }
        private void DrInfo_button_Click(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.GetDoctorInfo();
            DrInfo_dataGridView.DataSource = dt1;
            DrInfo_dataGridView.Refresh();
        }

        private void DrFeedback_button_Click(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.GetDoctorFeedback();
            DrInfo_dataGridView.DataSource = dt1;
            DrInfo_dataGridView.Refresh();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DrID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectYourDoctor_button_Click(object sender, EventArgs e)
        {
            if (PatientSSN_textBox.Text == "")
            {
                MessageBox.Show("Please Enter your SSN");
            }
            else
            {
                int result = controllerObj.ChooseDoctor(Convert.ToInt16(PatientSSN_textBox.Text), Convert.ToInt16(DrID_comboBox.Text));
                if (result == 0)
                {
                    MessageBox.Show("No Doctor was chosen");
                }
                else
                {
                    MessageBox.Show("Doctor is chosen successfully");
                }
            }

        }

        private void P_ChooseDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
