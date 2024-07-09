namespace HospitalApp
{
    partial class DoctorHome
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
            this.Setmedication_button = new System.Windows.Forms.Button();
            this.AddTests_button = new System.Windows.Forms.Button();
            this.MedicalRecords_button = new System.Windows.Forms.Button();
            this.Readfeedback_button = new System.Windows.Forms.Button();
            this.changepass_button = new System.Windows.Forms.Button();
            this.checkapp_button = new System.Windows.Forms.Button();
            this.ViewPatientsInfo_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Setmedication_button
            // 
            this.Setmedication_button.Location = new System.Drawing.Point(28, 98);
            this.Setmedication_button.Name = "Setmedication_button";
            this.Setmedication_button.Size = new System.Drawing.Size(127, 72);
            this.Setmedication_button.TabIndex = 0;
            this.Setmedication_button.Text = "Set Medication";
            this.Setmedication_button.UseVisualStyleBackColor = true;
            this.Setmedication_button.Click += new System.EventHandler(this.Setmedication_button_Click);
            // 
            // AddTests_button
            // 
            this.AddTests_button.Location = new System.Drawing.Point(179, 98);
            this.AddTests_button.Name = "AddTests_button";
            this.AddTests_button.Size = new System.Drawing.Size(118, 72);
            this.AddTests_button.TabIndex = 1;
            this.AddTests_button.Text = "Add Required Tests";
            this.AddTests_button.UseVisualStyleBackColor = true;
            this.AddTests_button.Click += new System.EventHandler(this.AddTests_button_Click);
            // 
            // MedicalRecords_button
            // 
            this.MedicalRecords_button.Location = new System.Drawing.Point(329, 98);
            this.MedicalRecords_button.Name = "MedicalRecords_button";
            this.MedicalRecords_button.Size = new System.Drawing.Size(114, 72);
            this.MedicalRecords_button.TabIndex = 2;
            this.MedicalRecords_button.Text = "Access medical records";
            this.MedicalRecords_button.UseVisualStyleBackColor = true;
            this.MedicalRecords_button.Click += new System.EventHandler(this.MedicalRecords_button_Click);
            // 
            // Readfeedback_button
            // 
            this.Readfeedback_button.Location = new System.Drawing.Point(481, 98);
            this.Readfeedback_button.Name = "Readfeedback_button";
            this.Readfeedback_button.Size = new System.Drawing.Size(117, 72);
            this.Readfeedback_button.TabIndex = 3;
            this.Readfeedback_button.Text = "Read feedback";
            this.Readfeedback_button.UseVisualStyleBackColor = true;
            this.Readfeedback_button.Click += new System.EventHandler(this.Readfeedback_button_Click);
            // 
            // changepass_button
            // 
            this.changepass_button.Location = new System.Drawing.Point(321, 224);
            this.changepass_button.Name = "changepass_button";
            this.changepass_button.Size = new System.Drawing.Size(142, 72);
            this.changepass_button.TabIndex = 4;
            this.changepass_button.Text = "change password";
            this.changepass_button.UseVisualStyleBackColor = true;
            this.changepass_button.Click += new System.EventHandler(this.changepass_button_Click);
            // 
            // checkapp_button
            // 
            this.checkapp_button.Location = new System.Drawing.Point(633, 98);
            this.checkapp_button.Name = "checkapp_button";
            this.checkapp_button.Size = new System.Drawing.Size(155, 71);
            this.checkapp_button.TabIndex = 5;
            this.checkapp_button.Text = "Check Appointments";
            this.checkapp_button.UseVisualStyleBackColor = true;
            this.checkapp_button.Click += new System.EventHandler(this.checkapp_button_Click);
            // 
            // ViewPatientsInfo_Button
            // 
            this.ViewPatientsInfo_Button.Location = new System.Drawing.Point(76, 224);
            this.ViewPatientsInfo_Button.Name = "ViewPatientsInfo_Button";
            this.ViewPatientsInfo_Button.Size = new System.Drawing.Size(156, 66);
            this.ViewPatientsInfo_Button.TabIndex = 6;
            this.ViewPatientsInfo_Button.Text = "View Patients Info";
            this.ViewPatientsInfo_Button.UseVisualStyleBackColor = true;
            this.ViewPatientsInfo_Button.Click += new System.EventHandler(this.ViewPatientsInfo_Button_Click);
            // 
            // DoctorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewPatientsInfo_Button);
            this.Controls.Add(this.checkapp_button);
            this.Controls.Add(this.changepass_button);
            this.Controls.Add(this.Readfeedback_button);
            this.Controls.Add(this.MedicalRecords_button);
            this.Controls.Add(this.AddTests_button);
            this.Controls.Add(this.Setmedication_button);
            this.Name = "DoctorHome";
            this.Text = "DoctorHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Setmedication_button;
        private System.Windows.Forms.Button AddTests_button;
        private System.Windows.Forms.Button MedicalRecords_button;
        private System.Windows.Forms.Button Readfeedback_button;
        private System.Windows.Forms.Button changepass_button;
        private System.Windows.Forms.Button checkapp_button;
        private System.Windows.Forms.Button ViewPatientsInfo_Button;
    }
}