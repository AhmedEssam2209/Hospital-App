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
    public partial class Arrange_Appointments : Form
    {
        Controller objcontroller;
        public Arrange_Appointments()
        {
            InitializeComponent();
            objcontroller = new Controller();
            DataTable dt1 = objcontroller.GetPatientsID();
            PID.DataSource = dt1;
            PID.DisplayMember = "PatientID";
            DataTable dt2 = objcontroller.GetDoctorsID();
            DID.DataSource = dt2;
            DID.DisplayMember = "DoctorID";
            DataTable dt3 = objcontroller.GetAvailableRooms();
            Rno.DataSource = dt3;
            Rno.DisplayMember = "RoomNumber";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cost.Text.Length == 0 || int.TryParse(cost.Text, out int x) || int.Parse(cost.Text) <= 0)
            {
                MessageBox.Show("Please enter a valid cost");
                return;
            }
            objcontroller.Add_Appointment(int.Parse(Convert.ToString(PID.SelectedValue)), int.Parse(Convert.ToString(DID.SelectedValue)),
                int.Parse(Convert.ToString(Rno.SelectedValue)),Convert.ToDateTime(date), int.Parse((cost.Text)));
            return;
        }
    }
}
