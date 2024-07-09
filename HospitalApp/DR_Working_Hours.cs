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
    public partial class DR_Working_Hours : Form
    {
        Controller objcontroller;
        public DR_Working_Hours()
        {
            InitializeComponent();
            objcontroller = new Controller();
            DataTable dt = objcontroller.GetDoctorsID();
            DR_ID.DataSource = dt;
            DR_ID.DisplayMember = "DoctorID";
        }

        private void Add_wh_Click(object sender, EventArgs e)
        {
            objcontroller.AddWorkingHours(int.Parse(Convert.ToString(Duration.SelectedValue)), int.Parse(Convert.ToString(DR_ID.SelectedValue)));
            return;
        }
    }
}
