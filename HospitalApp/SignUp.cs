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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorSignUp f = new DoctorSignUp();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientSignUp f = new PatientSignUp();
            f.Show();
        }
    }
}
