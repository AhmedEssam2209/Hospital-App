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
    public partial class ChPassManager : Form
    {
        Controller cont;
        public ChPassManager()
        {
            InitializeComponent();
            cont = new Controller();    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string real_pass = Convert.ToString(cont.GetMangPass());
            if (real_pass == textBox1.Text)
            {
               cont.UpdateManagerPass(textBox2.Text);
                MessageBox.Show("Password Changed Succesfully ");

                return;
            }
            else
            {
                MessageBox.Show("Wrong Old Password, please re-enter ");
                return;
            }
        }
    }
}
