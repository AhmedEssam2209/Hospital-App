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
using System.Xml.Linq;

namespace HospitalApp
{
    public partial class PatientSignUp : Form
    {
        Controller objcontroller;
        public PatientSignUp()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void PatientSignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void PSignUp_Click(object sender, EventArgs e)
        {
            int i = objcontroller.SignUp_Patient(FName.Text, Lname.Text, int.Parse(P_SSN.Text), int.Parse(P_PhoneNo.Text), P_Password.Text);
            if (i == 0)
            {
                MessageBox.Show("Appllication Failed");
                return;

            }

            else
            {
                MessageBox.Show("Appllication Succesful");
                return;
            }
        }
    }
}
