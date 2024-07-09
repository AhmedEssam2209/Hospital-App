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
    public partial class DoctorSignUp : Form
    {
        Controller objcontroller;

        public DoctorSignUp()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void DoctorSignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=objcontroller.SignUp_Doctor(Fname.Text, Lname.Text, int.Parse(ssn.Text), int.Parse(d_phno.Text), spec.Text, position.Text, int.Parse(exp_sal.Text), d_pass.Text);
            if (i ==0)
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
