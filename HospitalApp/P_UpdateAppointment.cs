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
    public partial class P_UpdateAppointment : Form
    {
        Controller controllerObj;

        public P_UpdateAppointment()
        {
            InitializeComponent();
            controllerObj = new Controller();
     
        }

        private void P_UpdateAppointment_Load(object sender, EventArgs e)
        {

        }

        private void Patient_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateAppointment_button_Click(object sender, EventArgs e)
        {
            if (PatSSN_textBox.Text == "" || AppointmentTime_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Your SSN and the appointment date ");

            }
            else
            {
                int result = controllerObj.UpdateAppointment(Convert.ToInt16(PatID_textBox.Text), AppointmentTime_textBox.Text);
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

        private void AppointmentTime_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteAppointment_button_Click(object sender, EventArgs e)
        {
            if (PatSSN_textBox.Text == ""|| AppointmentTime_textBox.Text=="")
            {
                MessageBox.Show("Please Enter Your SSN and the appointment date");

            }
            else
            {
                int result = controllerObj.DeleteAppointment(Convert.ToInt16(PatID_textBox.Text), AppointmentTime_textBox.Text);
                if (result == 0)
                {
                    MessageBox.Show("Appointment is not cancelled");
                }
                else
                {
                    MessageBox.Show("Appointment is cancelled successfully");
                }
            }
        }

        private void GetPatId_button_Click(object sender, EventArgs e)
        {
            if (PatSSN_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Your SSN");
            }
            else
            {
                PatID_textBox.Text = controllerObj.GetPatientID(Convert.ToInt16(PatSSN_textBox.Text)).ToString();

            }
        }
    }
}
