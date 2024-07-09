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
    public partial class Patient_Room : Form
    {
        Controller objcontroller;
        public Patient_Room()
        {
            InitializeComponent();
            objcontroller = new Controller();
            DataTable dt1 = objcontroller.GetPatientsFname();
            Fname.DataSource = dt1;
            Fname.DisplayMember = "Fname";
            DataTable dt2 = objcontroller.GetPatientsLname(Convert.ToString(Fname.SelectedValue));
            Lname.DataSource = dt2;
            Lname.DisplayMember = "Lname";
            DataTable dtr = objcontroller.GetAvailableRooms();
            RoomNo.DataSource = dt2;
            RoomNo.DisplayMember = "RoomNumber";
        }

        private void Assign_p_to_room_Click(object sender, EventArgs e)
        {
            objcontroller.SetRoomToUnavailbe(int.Parse(Convert.ToString(RoomNo.SelectedValue)));
            return;
        }
    }
}
