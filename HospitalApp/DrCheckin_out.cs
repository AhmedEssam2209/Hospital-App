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
    public partial class DrCheckin_out : Form
    {
        Controller objcontroller;
        public DrCheckin_out()
        {
            InitializeComponent();
            objcontroller = new Controller();
            DataTable dt = objcontroller.GetDoctorsID();
            DrId.DataSource = dt;
            DrId.DisplayMember = "DoctorID";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            objcontroller.DrCheckIn_Out(int.Parse(Convert.ToString(DrId.SelectedValue)), Convert.ToDateTime(CheckIn), Convert.ToDateTime(CheckOut));
            return;
        }
    }
}
