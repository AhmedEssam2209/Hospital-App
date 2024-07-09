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
    public partial class PatientHome : Form
    {
        public PatientHome()
        {
            InitializeComponent();
        }

        private void PatientHome_Load(object sender, EventArgs e)
        {

        }

        private void ViewMed_button_Click(object sender, EventArgs e)
        {
            View_Medications_Tests V = new View_Medications_Tests();
            V.Show();
        }

        private void ChangePassword_button_Click(object sender, EventArgs e)
        {
            PChangePass p = new PChangePass();
            p.Show();
        }

        private void ChooseDoctor_button_Click(object sender, EventArgs e)
        {
            P_ChooseDoctor p = new P_ChooseDoctor();
            p.Show();
        }

        private void UpdateAppointment_button_Click(object sender, EventArgs e)
        {
            P_UpdateAppointment p = new P_UpdateAppointment();
            p.Show();
        }

        private void GiveFeedback_button_Click(object sender, EventArgs e)
        {
            Give_Feedback g = new Give_Feedback();  
            g.Show();
        }

        private void AppointmentDetails_button_Click(object sender, EventArgs e)
        {
            AppointmentDetails A = new AppointmentDetails();
            A.Show();   
        }
    }
}
