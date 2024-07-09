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
    public partial class ViewPatientsInfo : Form
    {
        Controller ControllerObj;
        public ViewPatientsInfo()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void ViewAllPat_button_Click(object sender, EventArgs e)
        {
            if (DrID_textBox.Text=="")
            {
                MessageBox.Show("Please enter your ID");
            }
            else 
            {
                ControllerObj.ViewAllPatients(Convert.ToInt16(DrID_textBox.Text));
                DataTable dt = ControllerObj.ViewAllPatients(Convert.ToInt16(DrID_textBox.Text));
                GetallPat_dataGridView.DataSource = dt;
                GetallPat_dataGridView.Refresh();
            }
        }
    }
}
