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
    public partial class PChangePass : Form
    {
        Controller controllerObj;

        public PChangePass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PChangePassword_button_Click(object sender, EventArgs e)
        {
            if (PATFirstName_textbox.Text == "" || pChangePass_textBox.Text == ""|| PatientLastName_textBox.Text=="")
            {
                MessageBox.Show("Please, insert the new password and your first name and last name");
            }
            else
            {
                controllerObj.updatePatientpass(PATFirstName_textbox.Text, PatientLastName_textBox.Text, pChangePass_textBox.Text);
                MessageBox.Show("password updated successfully");
            }
        }
    }
}
