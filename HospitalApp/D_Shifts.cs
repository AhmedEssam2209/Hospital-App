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
    public partial class D_Shifts : Form
    {
        Controller objcontroller;
        public D_Shifts()
        {
            InitializeComponent();
            objcontroller = new Controller();
            DataTable dt = objcontroller.GetDoctorsID();
            DR_ID.DataSource = dt;
            DR_ID.DisplayMember = "DoctorID";
        }

        private void Assign_dr_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToString(DR_ID.SelectedValue), Convert.ToString(Shift.SelectedValue));
            dataGridView1.Refresh();
            return;
        }
    }
}
