namespace HospitalApp
{
    partial class ReceptionistHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Assign_p_to_r = new System.Windows.Forms.Button();
            this.Patient_info = new System.Windows.Forms.Button();
            this.Doctor_info = new System.Windows.Forms.Button();
            this.Check_Meds = new System.Windows.Forms.Button();
            this.D_Shift = new System.Windows.Forms.Button();
            this.DR_WH = new System.Windows.Forms.Button();
            this.arr_app = new System.Windows.Forms.Button();
            this.DrIn_out = new System.Windows.Forms.Button();
            this.NurseCheckIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Assign_p_to_r
            // 
            this.Assign_p_to_r.Location = new System.Drawing.Point(21, 45);
            this.Assign_p_to_r.Name = "Assign_p_to_r";
            this.Assign_p_to_r.Size = new System.Drawing.Size(202, 41);
            this.Assign_p_to_r.TabIndex = 0;
            this.Assign_p_to_r.Text = "Assign Patient To Room ";
            this.Assign_p_to_r.UseVisualStyleBackColor = true;
            this.Assign_p_to_r.Click += new System.EventHandler(this.Assign_p_to_r_Click);
            // 
            // Patient_info
            // 
            this.Patient_info.Location = new System.Drawing.Point(21, 124);
            this.Patient_info.Name = "Patient_info";
            this.Patient_info.Size = new System.Drawing.Size(202, 41);
            this.Patient_info.TabIndex = 3;
            this.Patient_info.Text = "Get Patient\'s Info";
            this.Patient_info.UseVisualStyleBackColor = true;
            this.Patient_info.Click += new System.EventHandler(this.Patient_info_Click);
            // 
            // Doctor_info
            // 
            this.Doctor_info.Location = new System.Drawing.Point(251, 45);
            this.Doctor_info.Name = "Doctor_info";
            this.Doctor_info.Size = new System.Drawing.Size(202, 41);
            this.Doctor_info.TabIndex = 4;
            this.Doctor_info.Text = "Get Doctor\'s Info";
            this.Doctor_info.UseVisualStyleBackColor = true;
            this.Doctor_info.Click += new System.EventHandler(this.Doctor_info_Click);
            // 
            // Check_Meds
            // 
            this.Check_Meds.Location = new System.Drawing.Point(502, 45);
            this.Check_Meds.Name = "Check_Meds";
            this.Check_Meds.Size = new System.Drawing.Size(202, 41);
            this.Check_Meds.TabIndex = 5;
            this.Check_Meds.Text = "Check Medications";
            this.Check_Meds.UseVisualStyleBackColor = true;
            this.Check_Meds.Click += new System.EventHandler(this.Check_Meds_Click);
            // 
            // D_Shift
            // 
            this.D_Shift.Location = new System.Drawing.Point(251, 198);
            this.D_Shift.Name = "D_Shift";
            this.D_Shift.Size = new System.Drawing.Size(202, 41);
            this.D_Shift.TabIndex = 6;
            this.D_Shift.Text = "Doctor\'s Shift";
            this.D_Shift.UseVisualStyleBackColor = true;
            this.D_Shift.Click += new System.EventHandler(this.D_Shift_Click);
            // 
            // DR_WH
            // 
            this.DR_WH.Location = new System.Drawing.Point(251, 124);
            this.DR_WH.Name = "DR_WH";
            this.DR_WH.Size = new System.Drawing.Size(202, 41);
            this.DR_WH.TabIndex = 7;
            this.DR_WH.Text = "Doctor\'s Working Hours";
            this.DR_WH.UseVisualStyleBackColor = true;
            this.DR_WH.Click += new System.EventHandler(this.DR_WH_Click);
            // 
            // arr_app
            // 
            this.arr_app.Location = new System.Drawing.Point(21, 198);
            this.arr_app.Name = "arr_app";
            this.arr_app.Size = new System.Drawing.Size(202, 41);
            this.arr_app.TabIndex = 8;
            this.arr_app.Text = "Arrange Appointments";
            this.arr_app.UseVisualStyleBackColor = true;
            this.arr_app.Click += new System.EventHandler(this.arr_app_Click);
            // 
            // DrIn_out
            // 
            this.DrIn_out.Location = new System.Drawing.Point(502, 124);
            this.DrIn_out.Name = "DrIn_out";
            this.DrIn_out.Size = new System.Drawing.Size(202, 41);
            this.DrIn_out.TabIndex = 9;
            this.DrIn_out.Text = "Doctor\'s Checkin/out";
            this.DrIn_out.UseVisualStyleBackColor = true;
            this.DrIn_out.Click += new System.EventHandler(this.DrIn_out_Click);
            // 
            // NurseCheckIn
            // 
            this.NurseCheckIn.Location = new System.Drawing.Point(502, 198);
            this.NurseCheckIn.Name = "NurseCheckIn";
            this.NurseCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NurseCheckIn.Size = new System.Drawing.Size(202, 41);
            this.NurseCheckIn.TabIndex = 10;
            this.NurseCheckIn.Text = "Nurse\'s Checkin/out";
            this.NurseCheckIn.UseVisualStyleBackColor = true;
            this.NurseCheckIn.Click += new System.EventHandler(this.NurseCheckIn_Click);
            // 
            // ReceptionistHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 283);
            this.Controls.Add(this.NurseCheckIn);
            this.Controls.Add(this.DrIn_out);
            this.Controls.Add(this.arr_app);
            this.Controls.Add(this.DR_WH);
            this.Controls.Add(this.D_Shift);
            this.Controls.Add(this.Check_Meds);
            this.Controls.Add(this.Doctor_info);
            this.Controls.Add(this.Patient_info);
            this.Controls.Add(this.Assign_p_to_r);
            this.Name = "ReceptionistHome";
            this.Text = "ReceptionistHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Assign_p_to_r;
        private System.Windows.Forms.Button Patient_info;
        private System.Windows.Forms.Button Doctor_info;
        private System.Windows.Forms.Button Check_Meds;
        private System.Windows.Forms.Button D_Shift;
        private System.Windows.Forms.Button DR_WH;
        private System.Windows.Forms.Button arr_app;
        private System.Windows.Forms.Button DrIn_out;
        private System.Windows.Forms.Button NurseCheckIn;
    }
}