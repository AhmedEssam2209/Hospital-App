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
    public partial class AppointmentDetails : Form
    {
        Controller ControllerObj;
        public AppointmentDetails()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewAppointment_button_Click(object sender, EventArgs e)
        {
            if (PatientSSN_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Your SSN");
            }
            else
            {
                ControllerObj.ViewAppointmentDetails(Convert.ToInt16(PatID_textBox.Text));
            }
        }

        private void GetPatID_button_Click(object sender, EventArgs e)
        {
            if (PatientSSN_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Your SSN");
            }
            else
            {
                PatID_textBox.Text = ControllerObj.GetPatientID(Convert.ToInt16(PatientSSN_textBox.Text)).ToString();

            }
        }
    }
}
