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
    public partial class ReceptionistHome : Form
    {
        public ReceptionistHome()
        {
            InitializeComponent();
        }

        private void Assign_p_to_r_Click(object sender, EventArgs e)
        {
            Patient_Room patient_Room = new Patient_Room();
            patient_Room.Show();
        }

        private void Patient_info_Click(object sender, EventArgs e)
        {
            Patient_INFO patient_INFO = new Patient_INFO();
            patient_INFO.Show();
        }

        private void Doctor_info_Click(object sender, EventArgs e)
        {
            Doctor_Info doctor_Info = new Doctor_Info();
            doctor_Info.Show();
        }

        private void Check_Meds_Click(object sender, EventArgs e)
        {
            Check_Medications check_Medications = new Check_Medications();
            check_Medications.Show();
        }

        private void D_Shift_Click(object sender, EventArgs e)
        {
            D_Shifts d_Shifts = new D_Shifts();
            d_Shifts.Show();
        }

        private void DR_WH_Click(object sender, EventArgs e)
        {
            DR_Working_Hours dR_Working_Hours = new DR_Working_Hours();
            dR_Working_Hours.Show();
        }

        private void arr_app_Click(object sender, EventArgs e)
        {
            Arrange_Appointments arrange_Appointments = new Arrange_Appointments();
            arrange_Appointments.Show();
        }

        private void DrIn_out_Click(object sender, EventArgs e)
        {
            DrCheckin_out drCheckin_Out = new DrCheckin_out();
            drCheckin_Out.Show();
        }

        private void NurseCheckIn_Click(object sender, EventArgs e)
        {
            NurseCheckIn_Out nurseCheckIn_Out = new NurseCheckIn_Out();
            nurseCheckIn_Out.Show();
        }
    }
}
