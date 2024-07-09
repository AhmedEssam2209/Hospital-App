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
    public partial class ManagerHome : Form
    {
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSalaries f = new SetSalaries();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedicationOrders f = new MedicationOrders();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hire hire = new Hire();
            hire.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fire fire = new Fire(); 
            fire.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChPassManager chPassManager = new ChPassManager();      
            chPassManager.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MachineMaintenence f = new MachineMaintenence();
            f.Show();
        }
    }
}
