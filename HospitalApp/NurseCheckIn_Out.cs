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
    public partial class NurseCheckIn_Out : Form
    {
        Controller objcontroller;
        public NurseCheckIn_Out()
        {
            InitializeComponent();
            objcontroller = new Controller();
            DataTable dt = objcontroller.GetNursesID();
            NurseID.DataSource = dt;
            NurseID.DisplayMember = "NurseID";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            objcontroller.NurseCheckIn_Out(int.Parse(Convert.ToString(NurseID.SelectedValue)), Convert.ToDateTime(CheckIn), Convert.ToDateTime(CheckOut));
            return;
        }
    }
}
