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
    public partial class DChangePass : Form
    {
        Controller controllerObj;
        public DChangePass()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""|| DLastName_textBox.Text=="")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                controllerObj.updateDoctorpass(textBox1.Text, DLastName_textBox.Text, textBox2.Text);
                MessageBox.Show("password updated successfully");
            }
        }
    }
}
