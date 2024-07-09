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
using System.Xml.Linq;

namespace HospitalApp
{
    public partial class DoctorLogin : Form
    {
        Controller objcontroller;
        public DoctorLogin()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Fname.Text;
            string[] Name = name.Split(' ');

            string real_pass = Convert.ToString(objcontroller.GetDocPass(Name[0], Name[1]));
            if (real_pass == "")
            {
                MessageBox.Show("There is no doctor registered with that name");
                return;

            }
            else if (real_pass == textBox1.Text)
            {
                DoctorHome doctorHome = new DoctorHome();
                doctorHome.Show();
                return;
            }
            else
            {
                MessageBox.Show("Wrong Password");
                return;
            }
        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
