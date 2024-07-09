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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalApp
{
    public partial class AddTests : Form
    {
        Controller controllerObj;
        public AddTests()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectPatients();
            PID_comboBox.DisplayMember = "PatientID";
            PID_comboBox.ValueMember = "PatientID";
            PID_comboBox.DataSource = dt;
            DataTable dt1 = controllerObj.SelectTests();
            TID_comboBox.DisplayMember = "ID";
            TID_comboBox.ValueMember = "ID";
            TID_comboBox.DataSource = dt1;
        }

        private void AddTests_Load(object sender, EventArgs e)
        {

        }

        private void AddTest_button_Click(object sender, EventArgs e)
        {
            controllerObj.AddTests(Convert.ToInt16(PID_comboBox.Text), Convert.ToInt16(TID_comboBox.Text));
        }
    }
}
