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
    public partial class ReadFeedback : Form
    {
        Controller controllerObj;
        public ReadFeedback()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DID_textBox.Text == "")
            {
                MessageBox.Show("Please Enter Doctor ID");
            }
            else
            {
                controllerObj.SelectFeedback(Convert.ToInt16(DID_textBox.Text));
                DataTable dt = controllerObj.SelectFeedback(Convert.ToInt16(DID_textBox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }
    }
}
