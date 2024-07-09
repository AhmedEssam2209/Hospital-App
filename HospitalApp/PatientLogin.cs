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
    public partial class PatientLogin : Form
    {

        Controller objcontroller;
        public PatientLogin()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Fname.Text;
            string[] Name = name.Split(' ');

            string real_pass = Convert.ToString(objcontroller.GetPatientPass(Name[0], Name[1]));
            if (real_pass == "")
            {
                MessageBox.Show("There is no patient registered with that name");
                return;

            }
            else if (real_pass == p_pass.Text)
            {
                PatientHome doctorHome = new PatientHome();
                doctorHome.Show();
                return;
            }
            else
            {
                MessageBox.Show("Wrong Password");
                return;
            }
        }
    }
}