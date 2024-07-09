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
    public partial class ManagerLogin : Form
    {
        Controller objcontroller;
        public ManagerLogin()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string real_pass = Convert.ToString(objcontroller.GetMangPass());
            if (real_pass == textBox1.Text)
            {
                ManagerHome managerHome = new ManagerHome();
                managerHome.Show();
                return;
            }
            else
            {
                MessageBox.Show("Wrong Password, please re-enter it");
                return;
            }
        }
    }
}
