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
    public partial class Setmedication : Form
    {
        Controller controllerObj;
        public Setmedication()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectPatients();
            patientID_combobox.DisplayMember = "PatientID";
            patientID_combobox.ValueMember = "PatientID";
            patientID_combobox.DataSource = dt;
        }

        private void SetMedication_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                controllerObj.AddMedication(Convert.ToInt16(patientID_combobox.Text), Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
                MessageBox.Show("Medication inserted successfully");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
