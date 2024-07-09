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
    public partial class DoctorHome : Form
    {
        public DoctorHome()
        {
            InitializeComponent();
        }

        private void Setmedication_button_Click(object sender, EventArgs e)
        {
            Setmedication M=new Setmedication();
            M.Show();
        }

        private void AddTests_button_Click(object sender, EventArgs e)
        {
            AddTests A=new AddTests(); 
            A.Show();
        }

        private void MedicalRecords_button_Click(object sender, EventArgs e)
        {
            AccessMedicalRecords A=new AccessMedicalRecords();
            A.Show();
        }

        private void Readfeedback_button_Click(object sender, EventArgs e)
        {
            ReadFeedback R=new ReadFeedback();
            R.Show();
        }

        private void changepass_button_Click(object sender, EventArgs e)
        {
            DChangePass D=new DChangePass();
            D.Show();
        }

        private void checkapp_button_Click(object sender, EventArgs e)
        {
            checkAppointments c=new checkAppointments();
            c.Show();
        }

        private void ViewPatientsInfo_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
