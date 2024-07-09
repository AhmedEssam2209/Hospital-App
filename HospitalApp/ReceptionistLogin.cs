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
    public partial class ReceptionistLogin : Form
    {
        Controller objcontroller;
        public ReceptionistLogin()
        {
            InitializeComponent();
            objcontroller = new Controller();   
        }

        private void recep_login_Click(object sender, EventArgs e)
        {
            string real_pass = Convert.ToString(objcontroller.GetRecepPass());
            if (real_pass == r_pass.Text)
            {
                ReceptionistHome receptionistHome = new ReceptionistHome();
                receptionistHome.Show();
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
