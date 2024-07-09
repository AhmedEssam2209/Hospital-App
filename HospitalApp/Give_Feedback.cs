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
    public partial class Give_Feedback : Form
    {
        Controller controllerObj;
        public Give_Feedback()
        {
            InitializeComponent();
            controllerObj = new Controller();
        
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitFeedback_button_Click(object sender, EventArgs e)
        {
            if (Feedback_textBox.Text == ""|| DRID_textBox.Text==""|| PID_textBox.Text=="")
            {
                MessageBox.Show("please enter a feedback , or make sure that you clicked on GetID button");
            }
            else
            {
               int result= controllerObj.GiveFeedback(Convert.ToInt16(PID_textBox.Text), Convert.ToInt16(DRID_textBox.Text), Feedback_textBox.Text);
                if (result == 0)
                {
                    MessageBox.Show("feedback is added successfully ");

                }
                else
                {
                    MessageBox.Show("feedback is not added ");
                }
            } 
        }

        private void Give_Feedback_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PSSN_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetPatID_button_Click(object sender, EventArgs e)
        {
            if(PSSN_textBox.Text=="")
            {
                MessageBox.Show("Please Enter Your SSN");
            }
            else
            {
                PID_textBox.Text = controllerObj.GetPatientID(Convert.ToInt16(PSSN_textBox.Text)).ToString();

            }
        }

      

        private void GetDrID_button_Click(object sender, EventArgs e)
        {
            if (DrFname_textBox.Text == ""|| DrLname_textBox.Text=="")
            {
                MessageBox.Show("Please Enter Doctor First Name and Last Name");
            }
            else
            {
                DRID_textBox.Text = controllerObj.GetDoctorID(DrFname_textBox.Text, DrLname_textBox.Text).ToString();

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
