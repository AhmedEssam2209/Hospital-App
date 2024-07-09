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
    public partial class Doctor_Info : Form
    {
        Controller objcontroller;
        public Doctor_Info()
        {
            InitializeComponent();
            objcontroller = new Controller();
            DataTable dt = objcontroller.GetDoctorsFname();
            Fname.DataSource = dt;
            Fname.DisplayMember = "Fname";
            DataTable dataTable = objcontroller.GetDoctorsLname(Convert.ToString(Fname.SelectedValue));
            Lname.DataSource = dataTable;
            Lname.DisplayMember = "Lname";
        }

        private void DInfo_Click(object sender, EventArgs e)
        {
            DataTable dt1 = objcontroller.GetDoctorsInfo(Convert.ToString(Fname.SelectedValue), Convert.ToString(Lname.SelectedValue));
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
        }
    }
}
