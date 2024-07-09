namespace HospitalApp
{
    partial class PatientHome
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
            this.ChangePassword_button = new System.Windows.Forms.Button();
            this.GiveFeedback_button = new System.Windows.Forms.Button();
            this.ViewMed_button = new System.Windows.Forms.Button();
            this.ChooseDoctor_button = new System.Windows.Forms.Button();
            this.UpdateAppointment_button = new System.Windows.Forms.Button();
            this.AppointmentDetails_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangePassword_button
            // 
            this.ChangePassword_button.Location = new System.Drawing.Point(518, 85);
            this.ChangePassword_button.Name = "ChangePassword_button";
            this.ChangePassword_button.Size = new System.Drawing.Size(175, 74);
            this.ChangePassword_button.TabIndex = 0;
            this.ChangePassword_button.Text = "ChangePassword";
            this.ChangePassword_button.UseVisualStyleBackColor = true;
            this.ChangePassword_button.Click += new System.EventHandler(this.ChangePassword_button_Click);
            // 
            // GiveFeedback_button
            // 
            this.GiveFeedback_button.Location = new System.Drawing.Point(518, 251);
            this.GiveFeedback_button.Name = "GiveFeedback_button";
            this.GiveFeedback_button.Size = new System.Drawing.Size(175, 75);
            this.GiveFeedback_button.TabIndex = 1;
            this.GiveFeedback_button.Text = "GiveFeedback";
            this.GiveFeedback_button.UseVisualStyleBackColor = true;
            this.GiveFeedback_button.Click += new System.EventHandler(this.GiveFeedback_button_Click);
            // 
            // ViewMed_button
            // 
            this.ViewMed_button.Location = new System.Drawing.Point(31, 85);
            this.ViewMed_button.Name = "ViewMed_button";
            this.ViewMed_button.Size = new System.Drawing.Size(199, 72);
            this.ViewMed_button.TabIndex = 2;
            this.ViewMed_button.Text = "View Medications Tests";
            this.ViewMed_button.UseVisualStyleBackColor = true;
            this.ViewMed_button.Click += new System.EventHandler(this.ViewMed_button_Click);
            // 
            // ChooseDoctor_button
            // 
            this.ChooseDoctor_button.Location = new System.Drawing.Point(267, 85);
            this.ChooseDoctor_button.Name = "ChooseDoctor_button";
            this.ChooseDoctor_button.Size = new System.Drawing.Size(187, 72);
            this.ChooseDoctor_button.TabIndex = 3;
            this.ChooseDoctor_button.Text = "ChooseDoctor";
            this.ChooseDoctor_button.UseVisualStyleBackColor = true;
            this.ChooseDoctor_button.Click += new System.EventHandler(this.ChooseDoctor_button_Click);
            // 
            // UpdateAppointment_button
            // 
            this.UpdateAppointment_button.Location = new System.Drawing.Point(271, 251);
            this.UpdateAppointment_button.Name = "UpdateAppointment_button";
            this.UpdateAppointment_button.Size = new System.Drawing.Size(183, 70);
            this.UpdateAppointment_button.TabIndex = 4;
            this.UpdateAppointment_button.Text = "Update Appointment Time";
            this.UpdateAppointment_button.UseVisualStyleBackColor = true;
            this.UpdateAppointment_button.Click += new System.EventHandler(this.UpdateAppointment_button_Click);
            // 
            // AppointmentDetails_button
            // 
            this.AppointmentDetails_button.Location = new System.Drawing.Point(31, 251);
            this.AppointmentDetails_button.Name = "AppointmentDetails_button";
            this.AppointmentDetails_button.Size = new System.Drawing.Size(183, 70);
            this.AppointmentDetails_button.TabIndex = 5;
            this.AppointmentDetails_button.Text = "Appointment Details";
            this.AppointmentDetails_button.UseVisualStyleBackColor = true;
            this.AppointmentDetails_button.Click += new System.EventHandler(this.AppointmentDetails_button_Click);
            // 
            // PatientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.AppointmentDetails_button);
            this.Controls.Add(this.UpdateAppointment_button);
            this.Controls.Add(this.ChooseDoctor_button);
            this.Controls.Add(this.ViewMed_button);
            this.Controls.Add(this.GiveFeedback_button);
            this.Controls.Add(this.ChangePassword_button);
            this.Name = "PatientHome";
            this.Text = "PatientHome";
            this.Load += new System.EventHandler(this.PatientHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangePassword_button;
        private System.Windows.Forms.Button GiveFeedback_button;
        private System.Windows.Forms.Button ViewMed_button;
        private System.Windows.Forms.Button ChooseDoctor_button;
        private System.Windows.Forms.Button UpdateAppointment_button;
        private System.Windows.Forms.Button AppointmentDetails_button;
    }
}