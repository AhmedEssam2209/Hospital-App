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
    public partial class Hire : Form
    {
        Controller cont;
        public Hire()
        {
            InitializeComponent();
            cont = new Controller();
            DataTable dt = cont.SelectAllNOThiredDoctors();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "FName";
            comboBox1.ValueMember = "DoctorID";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = cont.UpdateDoctorHire(Convert.ToInt32(comboBox1.SelectedValue));
        }
    }
}
