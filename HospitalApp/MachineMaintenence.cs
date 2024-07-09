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
    public partial class MachineMaintenence : Form
    {
        Controller cont;
        public MachineMaintenence()
        {
            InitializeComponent();
            cont = new Controller();
            DataTable dt = cont.SelectAllMachines();

            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "MaintCost";
            comboBox1.DataSource = dt;
        }

        private void MachineMaintenence_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.SelectedValue.ToString();
            DataTable dt = cont.SelectAllMachines();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = cont.InsertMachTrans(Convert.ToInt32(comboBox1.DisplayMember), Convert.ToInt32(comboBox1.SelectedValue));
        }
    }
}
