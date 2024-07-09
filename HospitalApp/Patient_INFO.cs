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
    public partial class Patient_INFO : Form
    {
        Controller objcontroller;
        public Patient_INFO()
        {
            InitializeComponent();
            objcontroller = new Controller();
            DataTable dt = objcontroller.GetPatientsFname();
            Pname.DataSource = dt;
            Pname.DisplayMember = "Fname";
            DataTable dataTable = objcontroller.GetPatientsLname(Convert.ToString(Pname.SelectedValue));
            Lname.DataSource = dataTable;
            Lname.DisplayMember= "Lname";
        }

        private void Info_Click(object sender, EventArgs e)
        {
            DataTable dt1 = objcontroller.GetPatientsInfo(Convert.ToString(Pname.SelectedValue), Convert.ToString(Lname.SelectedValue));
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
        }
    }
}
