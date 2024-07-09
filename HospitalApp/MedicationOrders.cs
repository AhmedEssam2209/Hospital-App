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
    public partial class MedicationOrders : Form
    {
        Controller cont;

        public MedicationOrders()
        {
            InitializeComponent();
            cont = new Controller();
            DataTable dt = cont.SelectAllDrugs();

            comboBox1.DisplayMember = "DrugID";
            comboBox1.ValueMember = "Cost";

            comboBox1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Quantity Of Drug");
                return;
            }
            comboBox1.ValueMember = "Cost";

            decimal price = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(comboBox1.SelectedValue);
            textBox2.Text = price.ToString();
            DataTable dt = cont.SelectAllDrugs(); 
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "DrugID";

            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Quantity Of Drug And Click Refresh");
                return;
            }
            int i = cont.InsertPharmaTrans(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            if (i==0)
            {
                MessageBox.Show("Transaction Failed");

            }
            MessageBox.Show("Transaction Successful");

            cont.UpdateDrugQuantity(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(textBox1.Text));
        }
    }
}
