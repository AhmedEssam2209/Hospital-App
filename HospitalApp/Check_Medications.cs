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
    public partial class Check_Medications : Form
    {
        Controller objcontroller;
        public Check_Medications()
        {
            InitializeComponent();
            objcontroller = new Controller();
            DataTable dt = objcontroller.GetDrugsID();
            DrugID.DataSource = dt;
            DrugID.DisplayMember = "DrugID";
        }

        private void CheckMed_Click(object sender, EventArgs e)
        {
            QTY.Text = Convert.ToString(objcontroller.GetRemainingDrugQty(int.Parse(Convert.ToString(DrugID.SelectedValue))));
            return;
        }
    }
}
